using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CollisionChaosEvent
{
    // StructProperty /Script/Engine.CollisionChaosEvent:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.CollisionChaosEvent:AccumulatedImpulse
    static readonly int AccumulatedImpulse_Offset;
    public System.DoubleNumerics.Vector3 AccumulatedImpulse;
    
    // StructProperty /Script/Engine.CollisionChaosEvent:Normal
    static readonly int Normal_Offset;
    public System.DoubleNumerics.Vector3 Normal;
    
    // FloatProperty /Script/Engine.CollisionChaosEvent:PenetrationDepth
    static readonly int PenetrationDepth_Offset;
    public float PenetrationDepth;
    
    // StructProperty /Script/Engine.CollisionChaosEvent:Body1
    static readonly int Body1_Offset;
    public UnrealSharp.Engine.CollisionChaosEventBodyInfo Body1;
    
    // StructProperty /Script/Engine.CollisionChaosEvent:Body2
    static readonly int Body2_Offset;
    public UnrealSharp.Engine.CollisionChaosEventBodyInfo Body2;
    
    
    public static readonly int NativeDataSize;
    static CollisionChaosEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CollisionChaosEvent");
        
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        AccumulatedImpulse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AccumulatedImpulse");
        Normal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Normal");
        PenetrationDepth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PenetrationDepth");
        Body1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Body1");
        Body2_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Body2");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CollisionChaosEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            AccumulatedImpulse = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AccumulatedImpulse_Offset), 0, null);
            Normal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Normal_Offset), 0, null);
            PenetrationDepth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PenetrationDepth_Offset), 0, null);
            Body1 = UnrealSharp.Engine.CollisionChaosEventBodyInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, Body1_Offset), 0, null);
            Body2 = UnrealSharp.Engine.CollisionChaosEventBodyInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, Body2_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AccumulatedImpulse_Offset), 0, null, AccumulatedImpulse);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Normal_Offset), 0, null, Normal);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PenetrationDepth_Offset), 0, null, PenetrationDepth);
            UnrealSharp.Engine.CollisionChaosEventBodyInfoMarshaler.ToNative(IntPtr.Add(Buffer, Body1_Offset), 0, null, Body1);
            UnrealSharp.Engine.CollisionChaosEventBodyInfoMarshaler.ToNative(IntPtr.Add(Buffer, Body2_Offset), 0, null, Body2);
        }
    }
}

public static class CollisionChaosEventMarshaler
{
    public static CollisionChaosEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CollisionChaosEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CollisionChaosEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CollisionChaosEvent.NativeDataSize;
    }
}