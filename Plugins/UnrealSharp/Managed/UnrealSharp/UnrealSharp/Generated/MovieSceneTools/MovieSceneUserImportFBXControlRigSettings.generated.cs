// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UClass]
public partial class MovieSceneUserImportFBXControlRigSettings : UnrealSharp.CoreUObject.Object
{
    
    static MovieSceneUserImportFBXControlRigSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneUserImportFBXControlRigSettings");
        
        
        LoadControlMappingsFromPreset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadControlMappingsFromPreset");
        LoadControlMappingsFromPreset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadControlMappingsFromPreset_NativeFunction);
        LoadControlMappingsFromPreset_bMetaHumanPreset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadControlMappingsFromPreset_NativeFunction, "bMetaHumanPreset");
        
        
    }
    
    protected MovieSceneUserImportFBXControlRigSettings(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MovieSceneTools.MovieSceneUserImportFBXControlRigSettings:LoadControlMappingsFromPreset
    static readonly IntPtr LoadControlMappingsFromPreset_NativeFunction;
    static readonly int LoadControlMappingsFromPreset_ParamsSize;
    static readonly int LoadControlMappingsFromPreset_bMetaHumanPreset_Offset;
    
    public void LoadControlMappingsFromPreset(bool bMetaHumanPreset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadControlMappingsFromPreset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, LoadControlMappingsFromPreset_bMetaHumanPreset_Offset), 0, null, bMetaHumanPreset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadControlMappingsFromPreset_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}