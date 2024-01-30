// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UClass]
abstract public partial class Factory : UnrealSharp.CoreUObject.Object
{
    
    static Factory()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("Factory");
        
        bCreateNew_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCreateNew");
        bCreateNew_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCreateNew");
        SupportedClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SupportedClass");
        ContextClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ContextClass");
        bEditAfterNew_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEditAfterNew");
        bEditAfterNew_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEditAfterNew");
        bEditorImport_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEditorImport");
        bEditorImport_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEditorImport");
        bText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bText");
        bText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bText");
        AutomatedImportData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutomatedImportData");
        AssetImportTask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetImportTask");
        
        
        IntPtr ScriptFactoryCreateFile_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptFactoryCreateFile");
        ScriptFactoryCreateFile_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptFactoryCreateFile_NativeFunction);
        ScriptFactoryCreateFile_InTask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptFactoryCreateFile_NativeFunction, "InTask");
        ScriptFactoryCreateFile_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptFactoryCreateFile_NativeFunction, "ReturnValue");
        
        IntPtr ScriptFactoryCanImport_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptFactoryCanImport");
        ScriptFactoryCanImport_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptFactoryCanImport_NativeFunction);
        ScriptFactoryCanImport_Filename_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptFactoryCanImport_NativeFunction, "Filename");
        ScriptFactoryCanImport_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptFactoryCanImport_NativeFunction, "ReturnValue");
        
        
    }
    
    protected Factory(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/UnrealEd.Factory:bCreateNew
    static readonly int bCreateNew_Offset;
    static readonly IntPtr bCreateNew_NativeProperty;
    
    public bool bCreateNew
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bCreateNew_NativeProperty, bCreateNew_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bCreateNew_NativeProperty, bCreateNew_Offset, value);
        }
    }
    
    // ClassProperty /Script/UnrealEd.Factory:SupportedClass
    static readonly int SupportedClass_Offset;
    
    public SubclassOf<UnrealSharp.CoreUObject.Object> SupportedClass
    {
        get
        {
            CheckObjectForValidity();
            return SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(NativeObject, SupportedClass_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(NativeObject, SupportedClass_Offset), 0, this, value);
        }
    }
    
    // ClassProperty /Script/UnrealEd.Factory:ContextClass
    static readonly int ContextClass_Offset;
    
    public SubclassOf<UnrealSharp.CoreUObject.Object> ContextClass
    {
        get
        {
            CheckObjectForValidity();
            return SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(NativeObject, ContextClass_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(NativeObject, ContextClass_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.Factory:bEditAfterNew
    static readonly int bEditAfterNew_Offset;
    static readonly IntPtr bEditAfterNew_NativeProperty;
    
    public bool bEditAfterNew
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEditAfterNew_NativeProperty, bEditAfterNew_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bEditAfterNew_NativeProperty, bEditAfterNew_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.Factory:bEditorImport
    static readonly int bEditorImport_Offset;
    static readonly IntPtr bEditorImport_NativeProperty;
    
    public bool bEditorImport
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEditorImport_NativeProperty, bEditorImport_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bEditorImport_NativeProperty, bEditorImport_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.Factory:bText
    static readonly int bText_Offset;
    static readonly IntPtr bText_NativeProperty;
    
    public bool bText
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bText_NativeProperty, bText_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bText_NativeProperty, bText_Offset, value);
        }
    }
    
    // ObjectProperty /Script/UnrealEd.Factory:AutomatedImportData
    static readonly int AutomatedImportData_Offset;
    
    public UnrealSharp.UnrealEd.AutomatedAssetImportData AutomatedImportData
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.UnrealEd.AutomatedAssetImportData>.FromNative(IntPtr.Add(NativeObject, AutomatedImportData_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.UnrealEd.AutomatedAssetImportData>.ToNative(IntPtr.Add(NativeObject, AutomatedImportData_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/UnrealEd.Factory:AssetImportTask
    static readonly int AssetImportTask_Offset;
    
    public UnrealSharp.UnrealEd.AssetImportTask AssetImportTask
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.UnrealEd.AssetImportTask>.FromNative(IntPtr.Add(NativeObject, AssetImportTask_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.UnrealEd.AssetImportTask>.ToNative(IntPtr.Add(NativeObject, AssetImportTask_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UnrealEd.Factory:ScriptFactoryCreateFile
    IntPtr ScriptFactoryCreateFile_NativeFunction;
    static readonly int ScriptFactoryCreateFile_ParamsSize;
    static readonly int ScriptFactoryCreateFile_InTask_Offset;
    static readonly int ScriptFactoryCreateFile_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual bool ScriptFactoryCreateFile(UnrealSharp.UnrealEd.AssetImportTask inTask)
    {
        unsafe
        {
            if (ScriptFactoryCreateFile_NativeFunction == IntPtr.Zero)
            {
                ScriptFactoryCreateFile_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ScriptFactoryCreateFile");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ScriptFactoryCreateFile_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.UnrealEd.AssetImportTask>.ToNative(IntPtr.Add(ParamsBuffer, ScriptFactoryCreateFile_InTask_Offset), 0, null, inTask);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptFactoryCreateFile_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ScriptFactoryCreateFile_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool ScriptFactoryCreateFile_Implementation(UnrealSharp.UnrealEd.AssetImportTask inTask)
    {
        return default(bool);
    }
    void Invoke_ScriptFactoryCreateFile(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.UnrealEd.AssetImportTask inTask = ObjectMarshaller<UnrealSharp.UnrealEd.AssetImportTask>.FromNative(IntPtr.Add(buffer, ScriptFactoryCreateFile_InTask_Offset), 0, null);
            bool returnValue = ScriptFactoryCreateFile_Implementation(inTask);
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    // Function /Script/UnrealEd.Factory:ScriptFactoryCanImport
    IntPtr ScriptFactoryCanImport_NativeFunction;
    static readonly int ScriptFactoryCanImport_ParamsSize;
    static readonly int ScriptFactoryCanImport_Filename_Offset;
    static readonly int ScriptFactoryCanImport_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual bool ScriptFactoryCanImport(string filename)
    {
        unsafe
        {
            if (ScriptFactoryCanImport_NativeFunction == IntPtr.Zero)
            {
                ScriptFactoryCanImport_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ScriptFactoryCanImport");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ScriptFactoryCanImport_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Filename_NativePtr = IntPtr.Add(ParamsBuffer,ScriptFactoryCanImport_Filename_Offset);
            StringMarshaller.ToNative(Filename_NativePtr,0,null,filename);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptFactoryCanImport_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ScriptFactoryCanImport_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Filename_NativePtr, 0);
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool ScriptFactoryCanImport_Implementation(string filename)
    {
        return default(bool);
    }
    void Invoke_ScriptFactoryCanImport(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            IntPtr Filename_NativePtr = IntPtr.Add(buffer,ScriptFactoryCanImport_Filename_Offset);
            string filename = StringMarshaller.FromNative(Filename_NativePtr,0,null);
            bool returnValue = ScriptFactoryCanImport_Implementation(filename);
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    
}