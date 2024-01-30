using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct BodyInstance
{
    // EnumProperty /Script/Engine.BodyInstance:SleepFamily
    static readonly int SleepFamily_Offset;
    public UnrealSharp.PhysicsCore.ESleepFamily SleepFamily;
    
    // BoolProperty /Script/Engine.BodyInstance:bUseCCD
    static readonly int bUseCCD_Offset;
    static readonly IntPtr bUseCCD_NativeProperty;
    public bool UseCCD;
    
    // BoolProperty /Script/Engine.BodyInstance:bIgnoreAnalyticCollisions
    static readonly int bIgnoreAnalyticCollisions_Offset;
    static readonly IntPtr bIgnoreAnalyticCollisions_NativeProperty;
    public bool IgnoreAnalyticCollisions;
    
    // BoolProperty /Script/Engine.BodyInstance:bNotifyRigidBodyCollision
    static readonly int bNotifyRigidBodyCollision_Offset;
    static readonly IntPtr bNotifyRigidBodyCollision_NativeProperty;
    public bool NotifyRigidBodyCollision;
    
    // BoolProperty /Script/Engine.BodyInstance:bSmoothEdgeCollisions
    static readonly int bSmoothEdgeCollisions_Offset;
    static readonly IntPtr bSmoothEdgeCollisions_NativeProperty;
    public bool SmoothEdgeCollisions;
    
    // BoolProperty /Script/Engine.BodyInstance:bInertiaConditioning
    static readonly int bInertiaConditioning_Offset;
    static readonly IntPtr bInertiaConditioning_NativeProperty;
    public bool InertiaConditioning;
    
    // ByteProperty /Script/Engine.BodyInstance:PositionSolverIterationCount
    static readonly int PositionSolverIterationCount_Offset;
    public byte PositionSolverIterationCount;
    
    // ByteProperty /Script/Engine.BodyInstance:VelocitySolverIterationCount
    static readonly int VelocitySolverIterationCount_Offset;
    public byte VelocitySolverIterationCount;
    
    // FloatProperty /Script/Engine.BodyInstance:MaxDepenetrationVelocity
    static readonly int MaxDepenetrationVelocity_Offset;
    public float MaxDepenetrationVelocity;
    
    // FloatProperty /Script/Engine.BodyInstance:MassInKgOverride
    static readonly int MassInKgOverride_Offset;
    public float MassInKgOverride;
    
    // FloatProperty /Script/Engine.BodyInstance:LinearDamping
    static readonly int LinearDamping_Offset;
    public float LinearDamping;
    
    // FloatProperty /Script/Engine.BodyInstance:AngularDamping
    static readonly int AngularDamping_Offset;
    public float AngularDamping;
    
    // StructProperty /Script/Engine.BodyInstance:COMNudge
    static readonly int COMNudge_Offset;
    public System.DoubleNumerics.Vector3 COMNudge;
    
    // FloatProperty /Script/Engine.BodyInstance:MassScale
    static readonly int MassScale_Offset;
    public float MassScale;
    
    // StructProperty /Script/Engine.BodyInstance:InertiaTensorScale
    static readonly int InertiaTensorScale_Offset;
    public System.DoubleNumerics.Vector3 InertiaTensorScale;
    
    // StructProperty /Script/Engine.BodyInstance:WalkableSlopeOverride
    static readonly int WalkableSlopeOverride_Offset;
    public UnrealSharp.Engine.WalkableSlopeOverride WalkableSlopeOverride;
    
    // ObjectProperty /Script/Engine.BodyInstance:PhysMaterialOverride
    static readonly int PhysMaterialOverride_Offset;
    public UnrealSharp.PhysicsCore.PhysicalMaterial PhysMaterialOverride;
    
    // FloatProperty /Script/Engine.BodyInstance:MaxAngularVelocity
    static readonly int MaxAngularVelocity_Offset;
    public float MaxAngularVelocity;
    
    // FloatProperty /Script/Engine.BodyInstance:CustomSleepThresholdMultiplier
    static readonly int CustomSleepThresholdMultiplier_Offset;
    public float CustomSleepThresholdMultiplier;
    
    // FloatProperty /Script/Engine.BodyInstance:StabilizationThresholdMultiplier
    static readonly int StabilizationThresholdMultiplier_Offset;
    public float StabilizationThresholdMultiplier;
    
    
    public static readonly int NativeDataSize;
    static BodyInstance()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BodyInstance");
        
        SleepFamily_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SleepFamily");
        bUseCCD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCCD");
        bUseCCD_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseCCD");
        bIgnoreAnalyticCollisions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreAnalyticCollisions");
        bIgnoreAnalyticCollisions_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIgnoreAnalyticCollisions");
        bNotifyRigidBodyCollision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNotifyRigidBodyCollision");
        bNotifyRigidBodyCollision_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bNotifyRigidBodyCollision");
        bSmoothEdgeCollisions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSmoothEdgeCollisions");
        bSmoothEdgeCollisions_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSmoothEdgeCollisions");
        bInertiaConditioning_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInertiaConditioning");
        bInertiaConditioning_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bInertiaConditioning");
        PositionSolverIterationCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionSolverIterationCount");
        VelocitySolverIterationCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VelocitySolverIterationCount");
        MaxDepenetrationVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDepenetrationVelocity");
        MassInKgOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MassInKgOverride");
        LinearDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinearDamping");
        AngularDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularDamping");
        COMNudge_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "COMNudge");
        MassScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MassScale");
        InertiaTensorScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InertiaTensorScale");
        WalkableSlopeOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WalkableSlopeOverride");
        PhysMaterialOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PhysMaterialOverride");
        MaxAngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAngularVelocity");
        CustomSleepThresholdMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomSleepThresholdMultiplier");
        StabilizationThresholdMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StabilizationThresholdMultiplier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BodyInstance(IntPtr InNativeStruct)
    {
        unsafe
        {
            SleepFamily = BlittableMarshaller<UnrealSharp.PhysicsCore.ESleepFamily>.FromNative(IntPtr.Add(InNativeStruct, SleepFamily_Offset), 0, null);
            UseCCD = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseCCD_NativeProperty, bUseCCD_Offset);
            IgnoreAnalyticCollisions = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIgnoreAnalyticCollisions_NativeProperty, bIgnoreAnalyticCollisions_Offset);
            NotifyRigidBodyCollision = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bNotifyRigidBodyCollision_NativeProperty, bNotifyRigidBodyCollision_Offset);
            SmoothEdgeCollisions = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSmoothEdgeCollisions_NativeProperty, bSmoothEdgeCollisions_Offset);
            InertiaConditioning = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bInertiaConditioning_NativeProperty, bInertiaConditioning_Offset);
            PositionSolverIterationCount = BlittableMarshaller<byte>.FromNative(IntPtr.Add(InNativeStruct, PositionSolverIterationCount_Offset), 0, null);
            VelocitySolverIterationCount = BlittableMarshaller<byte>.FromNative(IntPtr.Add(InNativeStruct, VelocitySolverIterationCount_Offset), 0, null);
            MaxDepenetrationVelocity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDepenetrationVelocity_Offset), 0, null);
            MassInKgOverride = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MassInKgOverride_Offset), 0, null);
            LinearDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LinearDamping_Offset), 0, null);
            AngularDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AngularDamping_Offset), 0, null);
            COMNudge = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, COMNudge_Offset), 0, null);
            MassScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MassScale_Offset), 0, null);
            InertiaTensorScale = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, InertiaTensorScale_Offset), 0, null);
            WalkableSlopeOverride = UnrealSharp.Engine.WalkableSlopeOverrideMarshaler.FromNative(IntPtr.Add(InNativeStruct, WalkableSlopeOverride_Offset), 0, null);
            PhysMaterialOverride = ObjectMarshaller<UnrealSharp.PhysicsCore.PhysicalMaterial>.FromNative(IntPtr.Add(InNativeStruct, PhysMaterialOverride_Offset), 0, null);
            MaxAngularVelocity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxAngularVelocity_Offset), 0, null);
            CustomSleepThresholdMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CustomSleepThresholdMultiplier_Offset), 0, null);
            StabilizationThresholdMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StabilizationThresholdMultiplier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.PhysicsCore.ESleepFamily>.ToNative(IntPtr.Add(Buffer, SleepFamily_Offset), 0, null, SleepFamily);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseCCD_NativeProperty, bUseCCD_Offset, UseCCD);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIgnoreAnalyticCollisions_NativeProperty, bIgnoreAnalyticCollisions_Offset, IgnoreAnalyticCollisions);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bNotifyRigidBodyCollision_NativeProperty, bNotifyRigidBodyCollision_Offset, NotifyRigidBodyCollision);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSmoothEdgeCollisions_NativeProperty, bSmoothEdgeCollisions_Offset, SmoothEdgeCollisions);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bInertiaConditioning_NativeProperty, bInertiaConditioning_Offset, InertiaConditioning);
            BlittableMarshaller<byte>.ToNative(IntPtr.Add(Buffer, PositionSolverIterationCount_Offset), 0, null, PositionSolverIterationCount);
            BlittableMarshaller<byte>.ToNative(IntPtr.Add(Buffer, VelocitySolverIterationCount_Offset), 0, null, VelocitySolverIterationCount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDepenetrationVelocity_Offset), 0, null, MaxDepenetrationVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MassInKgOverride_Offset), 0, null, MassInKgOverride);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LinearDamping_Offset), 0, null, LinearDamping);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AngularDamping_Offset), 0, null, AngularDamping);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, COMNudge_Offset), 0, null, COMNudge);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MassScale_Offset), 0, null, MassScale);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, InertiaTensorScale_Offset), 0, null, InertiaTensorScale);
            UnrealSharp.Engine.WalkableSlopeOverrideMarshaler.ToNative(IntPtr.Add(Buffer, WalkableSlopeOverride_Offset), 0, null, WalkableSlopeOverride);
            ObjectMarshaller<UnrealSharp.PhysicsCore.PhysicalMaterial>.ToNative(IntPtr.Add(Buffer, PhysMaterialOverride_Offset), 0, null, PhysMaterialOverride);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxAngularVelocity_Offset), 0, null, MaxAngularVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CustomSleepThresholdMultiplier_Offset), 0, null, CustomSleepThresholdMultiplier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StabilizationThresholdMultiplier_Offset), 0, null, StabilizationThresholdMultiplier);
        }
    }
}

public static class BodyInstanceMarshaler
{
    public static BodyInstance FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BodyInstance(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BodyInstance obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BodyInstance.NativeDataSize;
    }
}