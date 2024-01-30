using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UStruct]
public partial struct ResonanceAudioReverbPluginSettings
{
    // BoolProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:bEnableRoomEffects
    static readonly int bEnableRoomEffects_Offset;
    public bool EnableRoomEffects;
    
    // StructProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RoomPosition
    static readonly int RoomPosition_Offset;
    public System.DoubleNumerics.Vector3 RoomPosition;
    
    // StructProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RoomRotation
    static readonly int RoomRotation_Offset;
    public System.DoubleNumerics.Quaternion RoomRotation;
    
    // StructProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RoomDimensions
    static readonly int RoomDimensions_Offset;
    public System.DoubleNumerics.Vector3 RoomDimensions;
    
    // EnumProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:LeftWallMaterial
    static readonly int LeftWallMaterial_Offset;
    public UnrealSharp.ResonanceAudio.ERaMaterialName LeftWallMaterial;
    
    // EnumProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RightWallMaterial
    static readonly int RightWallMaterial_Offset;
    public UnrealSharp.ResonanceAudio.ERaMaterialName RightWallMaterial;
    
    // EnumProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:FloorMaterial
    static readonly int FloorMaterial_Offset;
    public UnrealSharp.ResonanceAudio.ERaMaterialName FloorMaterial;
    
    // EnumProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:CeilingMaterial
    static readonly int CeilingMaterial_Offset;
    public UnrealSharp.ResonanceAudio.ERaMaterialName CeilingMaterial;
    
    // EnumProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:FrontWallMaterial
    static readonly int FrontWallMaterial_Offset;
    public UnrealSharp.ResonanceAudio.ERaMaterialName FrontWallMaterial;
    
    // EnumProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:BackWallMaterial
    static readonly int BackWallMaterial_Offset;
    public UnrealSharp.ResonanceAudio.ERaMaterialName BackWallMaterial;
    
    // FloatProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReflectionScalar
    static readonly int ReflectionScalar_Offset;
    public float ReflectionScalar;
    
    // FloatProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReverbGain
    static readonly int ReverbGain_Offset;
    public float ReverbGain;
    
    // FloatProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReverbTimeModifier
    static readonly int ReverbTimeModifier_Offset;
    public float ReverbTimeModifier;
    
    // FloatProperty /Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReverbBrightness
    static readonly int ReverbBrightness_Offset;
    public float ReverbBrightness;
    
    
    public static readonly int NativeDataSize;
    static ResonanceAudioReverbPluginSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ResonanceAudioReverbPluginSettings");
        
        bEnableRoomEffects_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableRoomEffects");
        RoomPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RoomPosition");
        RoomRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RoomRotation");
        RoomDimensions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RoomDimensions");
        LeftWallMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeftWallMaterial");
        RightWallMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RightWallMaterial");
        FloorMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FloorMaterial");
        CeilingMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CeilingMaterial");
        FrontWallMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrontWallMaterial");
        BackWallMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackWallMaterial");
        ReflectionScalar_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReflectionScalar");
        ReverbGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbGain");
        ReverbTimeModifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbTimeModifier");
        ReverbBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbBrightness");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ResonanceAudioReverbPluginSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableRoomEffects = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableRoomEffects_Offset), 0, null);
            RoomPosition = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, RoomPosition_Offset), 0, null);
            RoomRotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, RoomRotation_Offset), 0, null);
            RoomDimensions = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, RoomDimensions_Offset), 0, null);
            LeftWallMaterial = BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative(IntPtr.Add(InNativeStruct, LeftWallMaterial_Offset), 0, null);
            RightWallMaterial = BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative(IntPtr.Add(InNativeStruct, RightWallMaterial_Offset), 0, null);
            FloorMaterial = BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative(IntPtr.Add(InNativeStruct, FloorMaterial_Offset), 0, null);
            CeilingMaterial = BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative(IntPtr.Add(InNativeStruct, CeilingMaterial_Offset), 0, null);
            FrontWallMaterial = BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative(IntPtr.Add(InNativeStruct, FrontWallMaterial_Offset), 0, null);
            BackWallMaterial = BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative(IntPtr.Add(InNativeStruct, BackWallMaterial_Offset), 0, null);
            ReflectionScalar = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReflectionScalar_Offset), 0, null);
            ReverbGain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbGain_Offset), 0, null);
            ReverbTimeModifier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbTimeModifier_Offset), 0, null);
            ReverbBrightness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbBrightness_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableRoomEffects_Offset), 0, null, EnableRoomEffects);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, RoomPosition_Offset), 0, null, RoomPosition);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, RoomRotation_Offset), 0, null, RoomRotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, RoomDimensions_Offset), 0, null, RoomDimensions);
            BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative(IntPtr.Add(Buffer, LeftWallMaterial_Offset), 0, null, LeftWallMaterial);
            BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative(IntPtr.Add(Buffer, RightWallMaterial_Offset), 0, null, RightWallMaterial);
            BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative(IntPtr.Add(Buffer, FloorMaterial_Offset), 0, null, FloorMaterial);
            BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative(IntPtr.Add(Buffer, CeilingMaterial_Offset), 0, null, CeilingMaterial);
            BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative(IntPtr.Add(Buffer, FrontWallMaterial_Offset), 0, null, FrontWallMaterial);
            BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative(IntPtr.Add(Buffer, BackWallMaterial_Offset), 0, null, BackWallMaterial);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReflectionScalar_Offset), 0, null, ReflectionScalar);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbGain_Offset), 0, null, ReverbGain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbTimeModifier_Offset), 0, null, ReverbTimeModifier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbBrightness_Offset), 0, null, ReverbBrightness);
        }
    }
}

public static class ResonanceAudioReverbPluginSettingsMarshaler
{
    public static ResonanceAudioReverbPluginSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ResonanceAudioReverbPluginSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ResonanceAudioReverbPluginSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ResonanceAudioReverbPluginSettings.NativeDataSize;
    }
}