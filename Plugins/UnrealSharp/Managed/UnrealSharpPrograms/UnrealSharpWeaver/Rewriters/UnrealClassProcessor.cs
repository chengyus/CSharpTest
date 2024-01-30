﻿using Mono.Cecil;
using Mono.Cecil.Cil;
using UnrealSharpWeaver.MetaData;

namespace UnrealSharpWeaver.Rewriters;

public static class UnrealClassProcessor
{ 
    public static void ProcessClasses(IEnumerable<TypeDefinition> classes, ApiMetaData assemblyMetadata)
    {
        var typeToClassMetaData = classes.ToDictionary(type => type, type => new ClassMetaData(type));
        assemblyMetadata.ClassMetaData = typeToClassMetaData.Values.ToArray();

        var rewrittenClasses = new HashSet<TypeDefinition>();
        foreach (var classData in typeToClassMetaData)
        {
            ProcessParentClass(classData.Key, typeToClassMetaData, ref rewrittenClasses);
        }
    }
    
    private static void ProcessParentClass(TypeDefinition type, IReadOnlyDictionary<TypeDefinition, ClassMetaData> classDictionary, ref HashSet<TypeDefinition> rewrittenClasses)
    {
        var baseType = type.BaseType.Resolve();
        
        if (baseType != null && classDictionary.ContainsKey(baseType) && !rewrittenClasses.Contains(baseType))
        {
            ProcessParentClass(baseType, classDictionary, ref rewrittenClasses);
        }

        if (rewrittenClasses.Contains(type))
        {
            return;
        }
        
        ProcessClass(type, classDictionary[type]);
        rewrittenClasses.Add(type);
    }
    
    private static void ProcessClass(TypeDefinition classTypeDefinition, ClassMetaData metadata)
    {
        // Rewrite all the properties of the class to make getters/setters that call Native code.
        var offsetsToInitialize = new List<Tuple<FieldDefinition, PropertyMetaData>>();
        var pointersToInitialize = new List<Tuple<FieldDefinition, PropertyMetaData>>();
        PropertyRewriterHelpers.ProcessProperties(ref offsetsToInitialize, ref pointersToInitialize, classTypeDefinition, metadata.Properties);

        List<FunctionMetaData> functionsToRewrite = metadata.Functions.ToList();
        functionsToRewrite.AddRange(metadata.VirtualFunctions.Select(virtualFunction => virtualFunction.FunctionMetaData));
        
        var functionPointersToInitialize = new Dictionary<FunctionMetaData, FieldDefinition>();
        var functionParamSizesToInitialize = new List<Tuple<FunctionMetaData, FieldDefinition>>();
        var functionParamOffsetsToInitialize = new List<Tuple<FunctionMetaData, List<Tuple<FieldDefinition, PropertyMetaData>>>>();
        var functionParamElementSizesToInitialize = new List<Tuple<FunctionMetaData, List<Tuple<FieldDefinition, PropertyMetaData>>>>();
        
        FunctionRewriterHelpers.ProcessMethods(
            functionsToRewrite, 
            metadata, 
            classTypeDefinition,
            ref functionPointersToInitialize,
            ref functionParamSizesToInitialize,
            ref functionParamOffsetsToInitialize,
            ref functionParamElementSizesToInitialize);
        
        // Add a field to cache the native UClass pointer.
        // Example: private static readonly nint NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MyActorClass");
        FieldDefinition nativeClassField = WeaverHelper.AddFieldToType(classTypeDefinition, "NativeClass", WeaverHelper.IntPtrType);
        
        ConstructorBuilder.CreateTypeInitializer(classTypeDefinition, Instruction.Create(OpCodes.Stsfld, nativeClassField), 
            [Instruction.Create(OpCodes.Call, WeaverHelper.GetNativeClassFromNameMethod)]);
        
        // Add the static constructor that will fetch the different offsets and pointers needed for a UnrealSharp class to work.
        ConstructorBuilder.InitializePropertyAndFunctionsResources(classTypeDefinition,
            nativeClassField,
            offsetsToInitialize,
            pointersToInitialize, 
            functionParamOffsetsToInitialize, 
            functionParamElementSizesToInitialize,
            functionPointersToInitialize, 
            functionParamSizesToInitialize);
    }
}