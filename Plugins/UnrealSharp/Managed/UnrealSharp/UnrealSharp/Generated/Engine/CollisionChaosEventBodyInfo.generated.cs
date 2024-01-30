using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CollisionChaosEventBodyInfo
{
    // StructProperty /Script/Engine.CollisionChaosEventBodyInfo:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    // StructProperty /Script/Engine.CollisionChaosEventBodyInfo:DeltaVelocity
    static readonly int DeltaVelocity_Offset;
    public System.DoubleNumerics.Vector3 DeltaVelocity;
    
    // StructProperty /Script/Engine.CollisionChaosEventBodyInfo:AngularVelocity
    static readonly int AngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 AngularVelocity;
    
    // FloatProperty /Script/Engine.CollisionChaosEventBodyInfo:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    // ObjectProperty /Script/Engine.CollisionChaosEventBodyInfo:PhysMaterial
    static readonly int PhysMaterial_Offset;
    public UnrealSharp.PhysicsCore.PhysicalMaterial PhysMaterial;
    
    // WeakObjectProperty /Script/Engine.CollisionChaosEventBodyInfo:Component
    static readonly int Component_Offset;
    public WeakObject<UnrealSharp.Engine.PrimitiveComponent> Component;
    
    // IntProperty /Script/Engine.CollisionChaosEventBodyInfo:BodyIndex
    static readonly int BodyIndex_Offset;
    public int BodyIndex;
    
    // NameProperty /Script/Engine.CollisionChaosEventBodyInfo:BoneName
    static readonly int BoneName_Offset;
    public Name BoneName;
    
    
    public static readonly int NativeDataSize;
    static CollisionChaosEventBodyInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CollisionChaosEventBodyInfo");
        
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        DeltaVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeltaVelocity");
        AngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularVelocity");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        PhysMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PhysMaterial");
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        BodyIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BodyIndex");
        BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CollisionChaosEventBodyInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
            DeltaVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, DeltaVelocity_Offset), 0, null);
            AngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AngularVelocity_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
            PhysMaterial = ObjectMarshaller<UnrealSharp.PhysicsCore.PhysicalMaterial>.FromNative(IntPtr.Add(InNativeStruct, PhysMaterial_Offset), 0, null);
            Component = BlittableMarshaller<WeakObject<UnrealSharp.Engine.PrimitiveComponent>>.FromNative(IntPtr.Add(InNativeStruct, Component_Offset), 0, null);
            BodyIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BodyIndex_Offset), 0, null);
            BoneName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, DeltaVelocity_Offset), 0, null, DeltaVelocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AngularVelocity_Offset), 0, null, AngularVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
            ObjectMarshaller<UnrealSharp.PhysicsCore.PhysicalMaterial>.ToNative(IntPtr.Add(Buffer, PhysMaterial_Offset), 0, null, PhysMaterial);
            BlittableMarshaller<WeakObject<UnrealSharp.Engine.PrimitiveComponent>>.ToNative(IntPtr.Add(Buffer, Component_Offset), 0, null, Component);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BodyIndex_Offset), 0, null, BodyIndex);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneName_Offset), 0, null, BoneName);
        }
    }
}

public static class CollisionChaosEventBodyInfoMarshaler
{
    public static CollisionChaosEventBodyInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CollisionChaosEventBodyInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CollisionChaosEventBodyInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CollisionChaosEventBodyInfo.NativeDataSize;
    }
}