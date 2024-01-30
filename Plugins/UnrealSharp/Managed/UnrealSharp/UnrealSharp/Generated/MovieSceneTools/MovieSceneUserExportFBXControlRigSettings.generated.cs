// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UClass]
public partial class MovieSceneUserExportFBXControlRigSettings : UnrealSharp.CoreUObject.Object
{
    
    static MovieSceneUserExportFBXControlRigSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneUserExportFBXControlRigSettings");
        
        FbxExportCompatibility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FbxExportCompatibility");
        bASCII_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bASCII");
        bASCII_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bASCII");
        bExportLocalTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportLocalTime");
        bExportLocalTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExportLocalTime");
        
        LoadControlMappingsFromPreset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadControlMappingsFromPreset");
        LoadControlMappingsFromPreset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadControlMappingsFromPreset_NativeFunction);
        LoadControlMappingsFromPreset_bMetaHumanPreset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadControlMappingsFromPreset_NativeFunction, "bMetaHumanPreset");
        
        
    }
    
    protected MovieSceneUserExportFBXControlRigSettings(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // EnumProperty /Script/MovieSceneTools.MovieSceneUserExportFBXControlRigSettings:FbxExportCompatibility
    static readonly int FbxExportCompatibility_Offset;
    
    public UnrealSharp.UnrealEd.EFbxExportCompatibility FbxExportCompatibility
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.UnrealEd.EFbxExportCompatibility>.FromNative(IntPtr.Add(NativeObject, FbxExportCompatibility_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.UnrealEd.EFbxExportCompatibility>.ToNative(IntPtr.Add(NativeObject, FbxExportCompatibility_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/MovieSceneTools.MovieSceneUserExportFBXControlRigSettings:bASCII
    static readonly int bASCII_Offset;
    static readonly IntPtr bASCII_NativeProperty;
    
    public bool bASCII
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bASCII_NativeProperty, bASCII_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bASCII_NativeProperty, bASCII_Offset, value);
        }
    }
    
    // BoolProperty /Script/MovieSceneTools.MovieSceneUserExportFBXControlRigSettings:bExportLocalTime
    static readonly int bExportLocalTime_Offset;
    static readonly IntPtr bExportLocalTime_NativeProperty;
    
    public bool bExportLocalTime
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bExportLocalTime_NativeProperty, bExportLocalTime_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bExportLocalTime_NativeProperty, bExportLocalTime_Offset, value);
        }
    }
    
    // Function /Script/MovieSceneTools.MovieSceneUserExportFBXControlRigSettings:LoadControlMappingsFromPreset
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