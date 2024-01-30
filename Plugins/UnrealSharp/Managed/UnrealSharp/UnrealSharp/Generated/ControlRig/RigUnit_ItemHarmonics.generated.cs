using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ItemHarmonics
{
    // StructProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveSpeed
    static readonly int WaveSpeed_Offset;
    public System.DoubleNumerics.Vector3 WaveSpeed;
    
    // StructProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveFrequency
    static readonly int WaveFrequency_Offset;
    public System.DoubleNumerics.Vector3 WaveFrequency;
    
    // StructProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveAmplitude
    static readonly int WaveAmplitude_Offset;
    public System.DoubleNumerics.Vector3 WaveAmplitude;
    
    // StructProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveOffset
    static readonly int WaveOffset_Offset;
    public System.DoubleNumerics.Vector3 WaveOffset;
    
    // StructProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveNoise
    static readonly int WaveNoise_Offset;
    public System.DoubleNumerics.Vector3 WaveNoise;
    
    // EnumProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveEase
    static readonly int WaveEase_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType WaveEase;
    
    // FloatProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveMinimum
    static readonly int WaveMinimum_Offset;
    public float WaveMinimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_ItemHarmonics:WaveMaximum
    static readonly int WaveMaximum_Offset;
    public float WaveMaximum;
    
    // EnumProperty /Script/ControlRig.RigUnit_ItemHarmonics:RotationOrder
    static readonly int RotationOrder_Offset;
    public UnrealSharp.AnimationCore.EEulerRotationOrder RotationOrder;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ItemHarmonics()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ItemHarmonics");
        
        WaveSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveSpeed");
        WaveFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveFrequency");
        WaveAmplitude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveAmplitude");
        WaveOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveOffset");
        WaveNoise_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveNoise");
        WaveEase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveEase");
        WaveMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveMinimum");
        WaveMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveMaximum");
        RotationOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOrder");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ItemHarmonics(IntPtr InNativeStruct)
    {
        unsafe
        {
            WaveSpeed = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveSpeed_Offset), 0, null);
            WaveFrequency = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveFrequency_Offset), 0, null);
            WaveAmplitude = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveAmplitude_Offset), 0, null);
            WaveOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveOffset_Offset), 0, null);
            WaveNoise = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, WaveNoise_Offset), 0, null);
            WaveEase = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, WaveEase_Offset), 0, null);
            WaveMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WaveMinimum_Offset), 0, null);
            WaveMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WaveMaximum_Offset), 0, null);
            RotationOrder = BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.FromNative(IntPtr.Add(InNativeStruct, RotationOrder_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveSpeed_Offset), 0, null, WaveSpeed);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveFrequency_Offset), 0, null, WaveFrequency);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveAmplitude_Offset), 0, null, WaveAmplitude);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveOffset_Offset), 0, null, WaveOffset);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, WaveNoise_Offset), 0, null, WaveNoise);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, WaveEase_Offset), 0, null, WaveEase);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WaveMinimum_Offset), 0, null, WaveMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WaveMaximum_Offset), 0, null, WaveMaximum);
            BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.ToNative(IntPtr.Add(Buffer, RotationOrder_Offset), 0, null, RotationOrder);
        }
    }
}

public static class RigUnit_ItemHarmonicsMarshaler
{
    public static RigUnit_ItemHarmonics FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ItemHarmonics(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ItemHarmonics obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ItemHarmonics.NativeDataSize;
    }
}