using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct TrajectorySample
{
    // FloatProperty /Script/Engine.TrajectorySample:AccumulatedSeconds
    static readonly int AccumulatedSeconds_Offset;
    public float AccumulatedSeconds;
    
    // StructProperty /Script/Engine.TrajectorySample:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/Engine.TrajectorySample:LinearVelocity
    static readonly int LinearVelocity_Offset;
    public System.DoubleNumerics.Vector3 LinearVelocity;
    
    
    public static readonly int NativeDataSize;
    static TrajectorySample()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TrajectorySample");
        
        AccumulatedSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AccumulatedSeconds");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        LinearVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinearVelocity");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TrajectorySample(IntPtr InNativeStruct)
    {
        unsafe
        {
            AccumulatedSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AccumulatedSeconds_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            LinearVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, LinearVelocity_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AccumulatedSeconds_Offset), 0, null, AccumulatedSeconds);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, LinearVelocity_Offset), 0, null, LinearVelocity);
        }
    }
}

public static class TrajectorySampleMarshaler
{
    public static TrajectorySample FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TrajectorySample(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TrajectorySample obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TrajectorySample.NativeDataSize;
    }
}