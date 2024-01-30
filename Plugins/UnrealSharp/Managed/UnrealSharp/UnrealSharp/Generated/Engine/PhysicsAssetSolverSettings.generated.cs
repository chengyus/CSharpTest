using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PhysicsAssetSolverSettings
{
    // IntProperty /Script/Engine.PhysicsAssetSolverSettings:PositionIterations
    static readonly int PositionIterations_Offset;
    public int PositionIterations;
    
    // IntProperty /Script/Engine.PhysicsAssetSolverSettings:VelocityIterations
    static readonly int VelocityIterations_Offset;
    public int VelocityIterations;
    
    // IntProperty /Script/Engine.PhysicsAssetSolverSettings:ProjectionIterations
    static readonly int ProjectionIterations_Offset;
    public int ProjectionIterations;
    
    // FloatProperty /Script/Engine.PhysicsAssetSolverSettings:CullDistance
    static readonly int CullDistance_Offset;
    public float CullDistance;
    
    // FloatProperty /Script/Engine.PhysicsAssetSolverSettings:MaxDepenetrationVelocity
    static readonly int MaxDepenetrationVelocity_Offset;
    public float MaxDepenetrationVelocity;
    
    // FloatProperty /Script/Engine.PhysicsAssetSolverSettings:FixedTimeStep
    static readonly int FixedTimeStep_Offset;
    public float FixedTimeStep;
    
    // BoolProperty /Script/Engine.PhysicsAssetSolverSettings:bUseLinearJointSolver
    static readonly int bUseLinearJointSolver_Offset;
    public bool UseLinearJointSolver;
    
    
    public static readonly int NativeDataSize;
    static PhysicsAssetSolverSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PhysicsAssetSolverSettings");
        
        PositionIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionIterations");
        VelocityIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VelocityIterations");
        ProjectionIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProjectionIterations");
        CullDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CullDistance");
        MaxDepenetrationVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDepenetrationVelocity");
        FixedTimeStep_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FixedTimeStep");
        bUseLinearJointSolver_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseLinearJointSolver");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PhysicsAssetSolverSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            PositionIterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PositionIterations_Offset), 0, null);
            VelocityIterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, VelocityIterations_Offset), 0, null);
            ProjectionIterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ProjectionIterations_Offset), 0, null);
            CullDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CullDistance_Offset), 0, null);
            MaxDepenetrationVelocity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDepenetrationVelocity_Offset), 0, null);
            FixedTimeStep = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FixedTimeStep_Offset), 0, null);
            UseLinearJointSolver = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseLinearJointSolver_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PositionIterations_Offset), 0, null, PositionIterations);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, VelocityIterations_Offset), 0, null, VelocityIterations);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ProjectionIterations_Offset), 0, null, ProjectionIterations);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CullDistance_Offset), 0, null, CullDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDepenetrationVelocity_Offset), 0, null, MaxDepenetrationVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FixedTimeStep_Offset), 0, null, FixedTimeStep);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseLinearJointSolver_Offset), 0, null, UseLinearJointSolver);
        }
    }
}

public static class PhysicsAssetSolverSettingsMarshaler
{
    public static PhysicsAssetSolverSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PhysicsAssetSolverSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PhysicsAssetSolverSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PhysicsAssetSolverSettings.NativeDataSize;
    }
}