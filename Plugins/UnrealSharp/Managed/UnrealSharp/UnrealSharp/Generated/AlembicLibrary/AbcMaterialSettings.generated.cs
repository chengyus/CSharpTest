using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcMaterialSettings
{
    // BoolProperty /Script/AlembicLibrary.AbcMaterialSettings:bCreateMaterials
    static readonly int bCreateMaterials_Offset;
    public bool CreateMaterials;
    
    // BoolProperty /Script/AlembicLibrary.AbcMaterialSettings:bFindMaterials
    static readonly int bFindMaterials_Offset;
    public bool FindMaterials;
    
    
    public static readonly int NativeDataSize;
    static AbcMaterialSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcMaterialSettings");
        
        bCreateMaterials_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCreateMaterials");
        bFindMaterials_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFindMaterials");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcMaterialSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            CreateMaterials = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCreateMaterials_Offset), 0, null);
            FindMaterials = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFindMaterials_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCreateMaterials_Offset), 0, null, CreateMaterials);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFindMaterials_Offset), 0, null, FindMaterials);
        }
    }
}

public static class AbcMaterialSettingsMarshaler
{
    public static AbcMaterialSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcMaterialSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcMaterialSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcMaterialSettings.NativeDataSize;
    }
}