using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ChainHarmonics_Wave
{
    // BoolProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveFrequency
    static readonly int WaveFrequency_Offset;
    public System.DoubleNumerics.Vector3 WaveFrequency;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveAmplitude
    static readonly int WaveAmplitude_Offset;
    public System.DoubleNumerics.Vector3 WaveAmplitude;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveOffset
    static readonly int WaveOffset_Offset;
    public System.DoubleNumerics.Vector3 WaveOffset;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveNoise
    static readonly int WaveNoise_Offset;
    public System.DoubleNumerics.Vector3 WaveNoise;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveMinimum
    static readonly int WaveMinimum_Offset;
    public float WaveMinimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveMaximum
    static readonly int WaveMaximum_Offset;
    public float WaveMaximum;
    
    // EnumProperty /Script/ControlRig.RigUnit_ChainHarmonics_Wave:WaveEase
    static readonly int WaveEase_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType WaveEase;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ChainHarmonics_Wave()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ChainHarmonics_Wave");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        WaveFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveFrequency");
        WaveAmplitude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveAmplitude");
        WaveOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveOffset");
        WaveNoise_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveNoise");
        WaveMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveMinimum");
        WaveMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveMaximum");
        WaveEase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveEase");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ChainHarmonics_Wave(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            WaveFrequency = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveFrequency_Offset), 0, null);
            WaveAmplitude = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveAmplitude_Offset), 0, null);
            WaveOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveOffset_Offset), 0, null);
            WaveNoise = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveNoise_Offset), 0, null);
            WaveMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WaveMinimum_Offset), 0, null);
            WaveMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WaveMaximum_Offset), 0, null);
            WaveEase = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, WaveEase_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveFrequency_Offset), 0, null, WaveFrequency);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveAmplitude_Offset), 0, null, WaveAmplitude);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveOffset_Offset), 0, null, WaveOffset);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveNoise_Offset), 0, null, WaveNoise);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WaveMinimum_Offset), 0, null, WaveMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WaveMaximum_Offset), 0, null, WaveMaximum);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, WaveEase_Offset), 0, null, WaveEase);
        }
    }
}

public static class RigUnit_ChainHarmonics_WaveMarshaler
{
    public static RigUnit_ChainHarmonics_Wave FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ChainHarmonics_Wave(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ChainHarmonics_Wave obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ChainHarmonics_Wave.NativeDataSize;
    }
}