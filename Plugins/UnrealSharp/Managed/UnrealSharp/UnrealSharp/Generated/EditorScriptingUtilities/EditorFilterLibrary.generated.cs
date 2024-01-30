// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UClass]
public partial class EditorFilterLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static EditorFilterLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("EditorFilterLibrary");
        
        
        BySelection_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "BySelection");
        BySelection_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(BySelection_NativeFunction);
        BySelection_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BySelection_NativeFunction, "TargetArray");
        BySelection_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(BySelection_NativeFunction, "TargetArray");
        BySelection_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BySelection_NativeFunction, "FilterType");
        BySelection_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BySelection_NativeFunction, "ReturnValue");
        BySelection_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(BySelection_NativeFunction, "ReturnValue");
        ByLevelName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ByLevelName");
        ByLevelName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ByLevelName_NativeFunction);
        ByLevelName_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLevelName_NativeFunction, "TargetArray");
        ByLevelName_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByLevelName_NativeFunction, "TargetArray");
        ByLevelName_LevelName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLevelName_NativeFunction, "LevelName");
        ByLevelName_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLevelName_NativeFunction, "FilterType");
        ByLevelName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLevelName_NativeFunction, "ReturnValue");
        ByLevelName_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByLevelName_NativeFunction, "ReturnValue");
        ByLayer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ByLayer");
        ByLayer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ByLayer_NativeFunction);
        ByLayer_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLayer_NativeFunction, "TargetArray");
        ByLayer_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByLayer_NativeFunction, "TargetArray");
        ByLayer_LayerName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLayer_NativeFunction, "LayerName");
        ByLayer_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLayer_NativeFunction, "FilterType");
        ByLayer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByLayer_NativeFunction, "ReturnValue");
        ByLayer_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByLayer_NativeFunction, "ReturnValue");
        ByIDName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ByIDName");
        ByIDName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ByIDName_NativeFunction);
        ByIDName_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByIDName_NativeFunction, "TargetArray");
        ByIDName_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByIDName_NativeFunction, "TargetArray");
        ByIDName_NameSubString_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByIDName_NativeFunction, "NameSubString");
        ByIDName_StringMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByIDName_NativeFunction, "StringMatch");
        ByIDName_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByIDName_NativeFunction, "FilterType");
        ByIDName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByIDName_NativeFunction, "ReturnValue");
        ByIDName_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByIDName_NativeFunction, "ReturnValue");
        ByClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ByClass");
        ByClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ByClass_NativeFunction);
        ByClass_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByClass_NativeFunction, "TargetArray");
        ByClass_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByClass_NativeFunction, "TargetArray");
        ByClass_ObjectClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByClass_NativeFunction, "ObjectClass");
        ByClass_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByClass_NativeFunction, "FilterType");
        ByClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByClass_NativeFunction, "ReturnValue");
        ByClass_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByClass_NativeFunction, "ReturnValue");
        ByActorTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ByActorTag");
        ByActorTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ByActorTag_NativeFunction);
        ByActorTag_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorTag_NativeFunction, "TargetArray");
        ByActorTag_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByActorTag_NativeFunction, "TargetArray");
        ByActorTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorTag_NativeFunction, "Tag");
        ByActorTag_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorTag_NativeFunction, "FilterType");
        ByActorTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorTag_NativeFunction, "ReturnValue");
        ByActorTag_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByActorTag_NativeFunction, "ReturnValue");
        ByActorLabel_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ByActorLabel");
        ByActorLabel_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ByActorLabel_NativeFunction);
        ByActorLabel_TargetArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorLabel_NativeFunction, "TargetArray");
        ByActorLabel_TargetArray_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByActorLabel_NativeFunction, "TargetArray");
        ByActorLabel_NameSubString_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorLabel_NativeFunction, "NameSubString");
        ByActorLabel_StringMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorLabel_NativeFunction, "StringMatch");
        ByActorLabel_FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorLabel_NativeFunction, "FilterType");
        ByActorLabel_bIgnoreCase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorLabel_NativeFunction, "bIgnoreCase");
        ByActorLabel_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ByActorLabel_NativeFunction, "ReturnValue");
        ByActorLabel_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ByActorLabel_NativeFunction, "ReturnValue");
        
        
    }
    
    protected EditorFilterLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:BySelection
    static readonly IntPtr BySelection_NativeFunction;
    static readonly int BySelection_ParamsSize;
    static readonly int BySelection_TargetArray_Offset;
    static readonly int BySelection_TargetArray_ElementSize;
    static readonly int BySelection_FilterType_Offset;
    static readonly int BySelection_ReturnValue_Offset;
    static readonly int BySelection_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.Engine.Actor> BySelection(System.Collections.Generic.IList<UnrealSharp.Engine.Actor> targetArray, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[BySelection_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, BySelection_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, BySelection_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, BySelection_FilterType_Offset), 0, null, filterType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, BySelection_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.Actor> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, BySelection_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> (1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, BySelection_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:ByLevelName
    static readonly IntPtr ByLevelName_NativeFunction;
    static readonly int ByLevelName_ParamsSize;
    static readonly int ByLevelName_TargetArray_Offset;
    static readonly int ByLevelName_TargetArray_ElementSize;
    static readonly int ByLevelName_LevelName_Offset;
    static readonly int ByLevelName_FilterType_Offset;
    static readonly int ByLevelName_ReturnValue_Offset;
    static readonly int ByLevelName_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.Engine.Actor> ByLevelName(System.Collections.Generic.IList<UnrealSharp.Engine.Actor> targetArray, Name levelName, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ByLevelName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, ByLevelName_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByLevelName_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, ByLevelName_LevelName_Offset), 0, null, levelName);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, ByLevelName_FilterType_Offset), 0, null, filterType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ByLevelName_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.Actor> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, ByLevelName_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> (1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByLevelName_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:ByLayer
    static readonly IntPtr ByLayer_NativeFunction;
    static readonly int ByLayer_ParamsSize;
    static readonly int ByLayer_TargetArray_Offset;
    static readonly int ByLayer_TargetArray_ElementSize;
    static readonly int ByLayer_LayerName_Offset;
    static readonly int ByLayer_FilterType_Offset;
    static readonly int ByLayer_ReturnValue_Offset;
    static readonly int ByLayer_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.Engine.Actor> ByLayer(System.Collections.Generic.IList<UnrealSharp.Engine.Actor> targetArray, Name layerName, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ByLayer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, ByLayer_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByLayer_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, ByLayer_LayerName_Offset), 0, null, layerName);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, ByLayer_FilterType_Offset), 0, null, filterType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ByLayer_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.Actor> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, ByLayer_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> (1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByLayer_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:ByIDName
    static readonly IntPtr ByIDName_NativeFunction;
    static readonly int ByIDName_ParamsSize;
    static readonly int ByIDName_TargetArray_Offset;
    static readonly int ByIDName_TargetArray_ElementSize;
    static readonly int ByIDName_NameSubString_Offset;
    static readonly int ByIDName_StringMatch_Offset;
    static readonly int ByIDName_FilterType_Offset;
    static readonly int ByIDName_ReturnValue_Offset;
    static readonly int ByIDName_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> ByIDName(System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> targetArray, string nameSubString, UnrealSharp.EditorScriptingUtilities.EEditorScriptingStringMatchType stringMatch = UnrealSharp.EditorScriptingUtilities.EEditorScriptingStringMatchType.Contains, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ByIDName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, ByIDName_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object>(1, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative, ByIDName_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            IntPtr NameSubString_NativePtr = IntPtr.Add(ParamsBuffer,ByIDName_NameSubString_Offset);
            StringMarshaller.ToNative(NameSubString_NativePtr,0,null,nameSubString);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(ParamsBuffer, ByIDName_StringMatch_Offset), 0, null, stringMatch);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, ByIDName_FilterType_Offset), 0, null, filterType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ByIDName_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, ByIDName_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> (1, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative, ByIDName_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            StringMarshaller.DestructInstance(NameSubString_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:ByClass
    static readonly IntPtr ByClass_NativeFunction;
    static readonly int ByClass_ParamsSize;
    static readonly int ByClass_TargetArray_Offset;
    static readonly int ByClass_TargetArray_ElementSize;
    static readonly int ByClass_ObjectClass_Offset;
    static readonly int ByClass_FilterType_Offset;
    static readonly int ByClass_ReturnValue_Offset;
    static readonly int ByClass_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> ByClass(System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> targetArray, SubclassOf<UnrealSharp.CoreUObject.Object> objectClass, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ByClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, ByClass_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object>(1, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative, ByClass_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, ByClass_ObjectClass_Offset), 0, null, objectClass);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, ByClass_FilterType_Offset), 0, null, filterType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ByClass_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, ByClass_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> (1, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative, ByClass_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorTag
    static readonly IntPtr ByActorTag_NativeFunction;
    static readonly int ByActorTag_ParamsSize;
    static readonly int ByActorTag_TargetArray_Offset;
    static readonly int ByActorTag_TargetArray_ElementSize;
    static readonly int ByActorTag_Tag_Offset;
    static readonly int ByActorTag_FilterType_Offset;
    static readonly int ByActorTag_ReturnValue_Offset;
    static readonly int ByActorTag_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.Engine.Actor> ByActorTag(System.Collections.Generic.IList<UnrealSharp.Engine.Actor> targetArray, Name tag, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ByActorTag_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, ByActorTag_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByActorTag_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, ByActorTag_Tag_Offset), 0, null, tag);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, ByActorTag_FilterType_Offset), 0, null, filterType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ByActorTag_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.Actor> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, ByActorTag_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> (1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByActorTag_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorLabel
    static readonly IntPtr ByActorLabel_NativeFunction;
    static readonly int ByActorLabel_ParamsSize;
    static readonly int ByActorLabel_TargetArray_Offset;
    static readonly int ByActorLabel_TargetArray_ElementSize;
    static readonly int ByActorLabel_NameSubString_Offset;
    static readonly int ByActorLabel_StringMatch_Offset;
    static readonly int ByActorLabel_FilterType_Offset;
    static readonly int ByActorLabel_bIgnoreCase_Offset;
    static readonly int ByActorLabel_ReturnValue_Offset;
    static readonly int ByActorLabel_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.Engine.Actor> ByActorLabel(System.Collections.Generic.IList<UnrealSharp.Engine.Actor> targetArray, string nameSubString, UnrealSharp.EditorScriptingUtilities.EEditorScriptingStringMatchType stringMatch = UnrealSharp.EditorScriptingUtilities.EEditorScriptingStringMatchType.Contains, UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType filterType = UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType.Include, bool bIgnoreCase = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ByActorLabel_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TargetArray_NativeBuffer = IntPtr.Add(ParamsBuffer, ByActorLabel_TargetArray_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> TargetArray_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByActorLabel_TargetArray_ElementSize);
            TargetArray_Marshaler.ToNative(TargetArray_NativeBuffer, 0, null, targetArray);
            IntPtr NameSubString_NativePtr = IntPtr.Add(ParamsBuffer,ByActorLabel_NameSubString_Offset);
            StringMarshaller.ToNative(NameSubString_NativePtr,0,null,nameSubString);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(ParamsBuffer, ByActorLabel_StringMatch_Offset), 0, null, stringMatch);
            BlittableMarshaller<UnrealSharp.EditorScriptingUtilities.EEditorScriptingFilterType>.ToNative(IntPtr.Add(ParamsBuffer, ByActorLabel_FilterType_Offset), 0, null, filterType);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, ByActorLabel_bIgnoreCase_Offset), 0, null, bIgnoreCase);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ByActorLabel_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.Actor> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, ByActorLabel_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> (1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, ByActorLabel_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            StringMarshaller.DestructInstance(NameSubString_NativePtr, 0);
            return returnValue;
        }
    }
    
    
}