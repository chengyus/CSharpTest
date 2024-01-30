using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SphereTraceByTraceChannel
{
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:Start
    static readonly int Start_Offset;
    public System.DoubleNumerics.Vector3 Start;
    
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:End
    static readonly int End_Offset;
    public System.DoubleNumerics.Vector3 End;
    
    // ByteProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:TraceChannel
    static readonly int TraceChannel_Offset;
    public UnrealSharp.Engine.ETraceTypeQuery TraceChannel;
    
    // FloatProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    // BoolProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:bHit
    static readonly int bHit_Offset;
    public bool Hit;
    
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:HitLocation
    static readonly int HitLocation_Offset;
    public System.DoubleNumerics.Vector3 HitLocation;
    
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByTraceChannel:HitNormal
    static readonly int HitNormal_Offset;
    public System.DoubleNumerics.Vector3 HitNormal;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SphereTraceByTraceChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SphereTraceByTraceChannel");
        
        Start_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Start");
        End_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "End");
        TraceChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TraceChannel");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        bHit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHit");
        HitLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitLocation");
        HitNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitNormal");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SphereTraceByTraceChannel(IntPtr InNativeStruct)
    {
        unsafe
        {
            Start = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Start_Offset), 0, null);
            End = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, End_Offset), 0, null);
            TraceChannel = BlittableMarshaller<UnrealSharp.Engine.ETraceTypeQuery>.FromNative(IntPtr.Add(InNativeStruct, TraceChannel_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
            Hit = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHit_Offset), 0, null);
            HitLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, HitLocation_Offset), 0, null);
            HitNormal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, HitNormal_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Start_Offset), 0, null, Start);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, End_Offset), 0, null, End);
            BlittableMarshaller<UnrealSharp.Engine.ETraceTypeQuery>.ToNative(IntPtr.Add(Buffer, TraceChannel_Offset), 0, null, TraceChannel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHit_Offset), 0, null, Hit);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, HitLocation_Offset), 0, null, HitLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, HitNormal_Offset), 0, null, HitNormal);
        }
    }
}

public static class RigUnit_SphereTraceByTraceChannelMarshaler
{
    public static RigUnit_SphereTraceByTraceChannel FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SphereTraceByTraceChannel(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SphereTraceByTraceChannel obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SphereTraceByTraceChannel.NativeDataSize;
    }
}