using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcConversionSettings
{
    // EnumProperty /Script/AlembicLibrary.AbcConversionSettings:Preset
    static readonly int Preset_Offset;
    public UnrealSharp.AlembicLibrary.EAbcConversionPreset Preset;
    
    // BoolProperty /Script/AlembicLibrary.AbcConversionSettings:bFlipU
    static readonly int bFlipU_Offset;
    public bool FlipU;
    
    // BoolProperty /Script/AlembicLibrary.AbcConversionSettings:bFlipV
    static readonly int bFlipV_Offset;
    public bool FlipV;
    
    // StructProperty /Script/AlembicLibrary.AbcConversionSettings:Scale
    static readonly int Scale_Offset;
    public System.DoubleNumerics.Vector3 Scale;
    
    // StructProperty /Script/AlembicLibrary.AbcConversionSettings:Rotation
    static readonly int Rotation_Offset;
    public System.DoubleNumerics.Vector3 Rotation;
    
    
    public static readonly int NativeDataSize;
    static AbcConversionSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcConversionSettings");
        
        Preset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Preset");
        bFlipU_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlipU");
        bFlipV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlipV");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcConversionSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Preset = BlittableMarshaller<UnrealSharp.AlembicLibrary.EAbcConversionPreset>.FromNative(IntPtr.Add(InNativeStruct, Preset_Offset), 0, null);
            FlipU = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlipU_Offset), 0, null);
            FlipV = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlipV_Offset), 0, null);
            Scale = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Rotation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AlembicLibrary.EAbcConversionPreset>.ToNative(IntPtr.Add(Buffer, Preset_Offset), 0, null, Preset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlipU_Offset), 0, null, FlipU);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlipV_Offset), 0, null, FlipV);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
        }
    }
}

public static class AbcConversionSettingsMarshaler
{
    public static AbcConversionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcConversionSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcConversionSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcConversionSettings.NativeDataSize;
    }
}