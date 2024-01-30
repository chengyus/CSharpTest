using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ChaosCrumblingEvent
{
    // ObjectProperty /Script/Engine.ChaosCrumblingEvent:Component
    static readonly int Component_Offset;
    public UnrealSharp.Engine.PrimitiveComponent Component;
    
    // StructProperty /Script/Engine.ChaosCrumblingEvent:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.ChaosCrumblingEvent:Orientation
    static readonly int Orientation_Offset;
    public System.DoubleNumerics.Quaternion Orientation;
    
    // StructProperty /Script/Engine.ChaosCrumblingEvent:LinearVelocity
    static readonly int LinearVelocity_Offset;
    public System.DoubleNumerics.Vector3 LinearVelocity;
    
    // StructProperty /Script/Engine.ChaosCrumblingEvent:AngularVelocity
    static readonly int AngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 AngularVelocity;
    
    // FloatProperty /Script/Engine.ChaosCrumblingEvent:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    // StructProperty /Script/Engine.ChaosCrumblingEvent:LocalBounds
    static readonly int LocalBounds_Offset;
    public UnrealSharp.CoreUObject.Box LocalBounds;
    
    
    public static readonly int NativeDataSize;
    static ChaosCrumblingEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosCrumblingEvent");
        
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Orientation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Orientation");
        LinearVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinearVelocity");
        AngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularVelocity");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        LocalBounds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalBounds");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosCrumblingEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Component = ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.FromNative(IntPtr.Add(InNativeStruct, Component_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Orientation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Orientation_Offset), 0, null);
            LinearVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, LinearVelocity_Offset), 0, null);
            AngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AngularVelocity_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
            LocalBounds = UnrealSharp.CoreUObject.BoxMarshaler.FromNative(IntPtr.Add(InNativeStruct, LocalBounds_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.ToNative(IntPtr.Add(Buffer, Component_Offset), 0, null, Component);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Orientation_Offset), 0, null, Orientation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, LinearVelocity_Offset), 0, null, LinearVelocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AngularVelocity_Offset), 0, null, AngularVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
            UnrealSharp.CoreUObject.BoxMarshaler.ToNative(IntPtr.Add(Buffer, LocalBounds_Offset), 0, null, LocalBounds);
        }
    }
}

public static class ChaosCrumblingEventMarshaler
{
    public static ChaosCrumblingEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosCrumblingEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosCrumblingEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosCrumblingEvent.NativeDataSize;
    }
}