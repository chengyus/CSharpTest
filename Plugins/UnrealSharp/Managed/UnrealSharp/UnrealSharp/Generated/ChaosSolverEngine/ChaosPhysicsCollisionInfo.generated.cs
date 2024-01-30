using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosSolverEngine;

[UStruct]
public partial struct ChaosPhysicsCollisionInfo
{
    // ObjectProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Component
    static readonly int Component_Offset;
    public UnrealSharp.Engine.PrimitiveComponent Component;
    
    // ObjectProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherComponent
    static readonly int OtherComponent_Offset;
    public UnrealSharp.Engine.PrimitiveComponent OtherComponent;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Normal
    static readonly int Normal_Offset;
    public System.DoubleNumerics.Vector3 Normal;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:AccumulatedImpulse
    static readonly int AccumulatedImpulse_Offset;
    public System.DoubleNumerics.Vector3 AccumulatedImpulse;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherVelocity
    static readonly int OtherVelocity_Offset;
    public System.DoubleNumerics.Vector3 OtherVelocity;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:AngularVelocity
    static readonly int AngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 AngularVelocity;
    
    // StructProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherAngularVelocity
    static readonly int OtherAngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 OtherAngularVelocity;
    
    // FloatProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    // FloatProperty /Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherMass
    static readonly int OtherMass_Offset;
    public float OtherMass;
    
    
    public static readonly int NativeDataSize;
    static ChaosPhysicsCollisionInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosPhysicsCollisionInfo");
        
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        OtherComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OtherComponent");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Normal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Normal");
        AccumulatedImpulse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AccumulatedImpulse");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        OtherVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OtherVelocity");
        AngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularVelocity");
        OtherAngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OtherAngularVelocity");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        OtherMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OtherMass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosPhysicsCollisionInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Component = ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.FromNative(IntPtr.Add(InNativeStruct, Component_Offset), 0, null);
            OtherComponent = ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.FromNative(IntPtr.Add(InNativeStruct, OtherComponent_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Normal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Normal_Offset), 0, null);
            AccumulatedImpulse = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AccumulatedImpulse_Offset), 0, null);
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
            OtherVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, OtherVelocity_Offset), 0, null);
            AngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AngularVelocity_Offset), 0, null);
            OtherAngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, OtherAngularVelocity_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
            OtherMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OtherMass_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.ToNative(IntPtr.Add(Buffer, Component_Offset), 0, null, Component);
            ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.ToNative(IntPtr.Add(Buffer, OtherComponent_Offset), 0, null, OtherComponent);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Normal_Offset), 0, null, Normal);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AccumulatedImpulse_Offset), 0, null, AccumulatedImpulse);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, OtherVelocity_Offset), 0, null, OtherVelocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AngularVelocity_Offset), 0, null, AngularVelocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, OtherAngularVelocity_Offset), 0, null, OtherAngularVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OtherMass_Offset), 0, null, OtherMass);
        }
    }
}

public static class ChaosPhysicsCollisionInfoMarshaler
{
    public static ChaosPhysicsCollisionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosPhysicsCollisionInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosPhysicsCollisionInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosPhysicsCollisionInfo.NativeDataSize;
    }
}