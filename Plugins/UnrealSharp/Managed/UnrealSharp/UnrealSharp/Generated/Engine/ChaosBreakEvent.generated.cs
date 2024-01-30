using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ChaosBreakEvent
{
    // ObjectProperty /Script/Engine.ChaosBreakEvent:Component
    static readonly int Component_Offset;
    public UnrealSharp.Engine.PrimitiveComponent Component;
    
    // StructProperty /Script/Engine.ChaosBreakEvent:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.ChaosBreakEvent:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    // StructProperty /Script/Engine.ChaosBreakEvent:AngularVelocity
    static readonly int AngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 AngularVelocity;
    
    // StructProperty /Script/Engine.ChaosBreakEvent:Extents
    static readonly int Extents_Offset;
    public System.DoubleNumerics.Vector3 Extents;
    
    // FloatProperty /Script/Engine.ChaosBreakEvent:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    // IntProperty /Script/Engine.ChaosBreakEvent:Index
    static readonly int Index_Offset;
    public int Index;
    
    // BoolProperty /Script/Engine.ChaosBreakEvent:bFromCrumble
    static readonly int bFromCrumble_Offset;
    public bool FromCrumble;
    
    
    public static readonly int NativeDataSize;
    static ChaosBreakEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosBreakEvent");
        
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        AngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularVelocity");
        Extents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Extents");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        bFromCrumble_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFromCrumble");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosBreakEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Component = ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.FromNative(IntPtr.Add(InNativeStruct, Component_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
            AngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AngularVelocity_Offset), 0, null);
            Extents = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Extents_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
            FromCrumble = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFromCrumble_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.ToNative(IntPtr.Add(Buffer, Component_Offset), 0, null, Component);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AngularVelocity_Offset), 0, null, AngularVelocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Extents_Offset), 0, null, Extents);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFromCrumble_Offset), 0, null, FromCrumble);
        }
    }
}

public static class ChaosBreakEventMarshaler
{
    public static ChaosBreakEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosBreakEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosBreakEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosBreakEvent.NativeDataSize;
    }
}