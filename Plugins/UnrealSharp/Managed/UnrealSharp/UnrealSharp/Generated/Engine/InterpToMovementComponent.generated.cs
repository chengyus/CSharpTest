// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class InterpToMovementComponent : UnrealSharp.Engine.MovementComponent
{
    
    static InterpToMovementComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterpToMovementComponent");
        
        Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Duration");
        bPauseOnImpact_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPauseOnImpact");
        bPauseOnImpact_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPauseOnImpact");
        bSweep_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSweep");
        TeleportType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TeleportType");
        BehaviourType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BehaviourType");
        bCheckIfStillInWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCheckIfStillInWorld");
        bForceSubStepping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceSubStepping");
        bForceSubStepping_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bForceSubStepping");
        MaxSimulationTimeStep_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSimulationTimeStep");
        MaxSimulationIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSimulationIterations");
        ControlPoints_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlPoints");
        ControlPoints_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ControlPoints");
        
        StopSimulating_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StopSimulating");
        StopSimulating_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StopSimulating_NativeFunction);
        StopSimulating_HitResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StopSimulating_NativeFunction, "HitResult");
        RestartMovement_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RestartMovement");
        RestartMovement_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RestartMovement_NativeFunction);
        RestartMovement_InitialDirection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RestartMovement_NativeFunction, "InitialDirection");
        ResetControlPoints_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetControlPoints");
        FinaliseControlPoints_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FinaliseControlPoints");
        AddControlPointPosition_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddControlPointPosition");
        AddControlPointPosition_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddControlPointPosition_NativeFunction);
        AddControlPointPosition_Pos_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddControlPointPosition_NativeFunction, "Pos");
        AddControlPointPosition_bPositionIsRelative_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddControlPointPosition_NativeFunction, "bPositionIsRelative");
        
        
    }
    
    protected InterpToMovementComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.InterpToMovementComponent:Duration
    static readonly int Duration_Offset;
    
    public float Duration
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Duration_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Duration_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.InterpToMovementComponent:bPauseOnImpact
    static readonly int bPauseOnImpact_Offset;
    static readonly IntPtr bPauseOnImpact_NativeProperty;
    
    public bool bPauseOnImpact
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bPauseOnImpact_NativeProperty, bPauseOnImpact_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bPauseOnImpact_NativeProperty, bPauseOnImpact_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.InterpToMovementComponent:bSweep
    static readonly int bSweep_Offset;
    
    public bool bSweep
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bSweep_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bSweep_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/Engine.InterpToMovementComponent:TeleportType
    static readonly int TeleportType_Offset;
    
    public UnrealSharp.Engine.ETeleportType TeleportType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.ETeleportType>.FromNative(IntPtr.Add(NativeObject, TeleportType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.ETeleportType>.ToNative(IntPtr.Add(NativeObject, TeleportType_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/Engine.InterpToMovementComponent:BehaviourType
    static readonly int BehaviourType_Offset;
    
    public UnrealSharp.Engine.EInterpToBehaviourType BehaviourType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.EInterpToBehaviourType>.FromNative(IntPtr.Add(NativeObject, BehaviourType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.EInterpToBehaviourType>.ToNative(IntPtr.Add(NativeObject, BehaviourType_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.InterpToMovementComponent:bCheckIfStillInWorld
    static readonly int bCheckIfStillInWorld_Offset;
    
    public bool bCheckIfStillInWorld
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCheckIfStillInWorld_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bCheckIfStillInWorld_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.InterpToMovementComponent:bForceSubStepping
    static readonly int bForceSubStepping_Offset;
    static readonly IntPtr bForceSubStepping_NativeProperty;
    
    public bool bForceSubStepping
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bForceSubStepping_NativeProperty, bForceSubStepping_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bForceSubStepping_NativeProperty, bForceSubStepping_Offset, value);
        }
    }
    
    // FloatProperty /Script/Engine.InterpToMovementComponent:MaxSimulationTimeStep
    static readonly int MaxSimulationTimeStep_Offset;
    
    public float MaxSimulationTimeStep
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxSimulationTimeStep_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxSimulationTimeStep_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/Engine.InterpToMovementComponent:MaxSimulationIterations
    static readonly int MaxSimulationIterations_Offset;
    
    public int MaxSimulationIterations
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MaxSimulationIterations_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, MaxSimulationIterations_Offset), 0, this, value);
        }
    }
    
    // ArrayProperty /Script/Engine.InterpToMovementComponent:ControlPoints
    static readonly int ControlPoints_Offset;
    static readonly IntPtr ControlPoints_NativeProperty;
    UnrealArrayReadWriteMarshaler<UnrealSharp.Engine.InterpControlPoint> ControlPoints_Wrapper = null;
    
    public System.Collections.Generic.IList<UnrealSharp.Engine.InterpControlPoint> ControlPoints
    {
        get
        {
            if(ControlPoints_Wrapper == null)
            {
                ControlPoints_Wrapper = new UnrealArrayReadWriteMarshaler<UnrealSharp.Engine.InterpControlPoint>(1, ControlPoints_NativeProperty, UnrealSharp.Engine.InterpControlPointMarshaler.ToNative, UnrealSharp.Engine.InterpControlPointMarshaler.FromNative);
            }
            
            return ControlPoints_Wrapper.FromNative(IntPtr.Add(NativeObject,ControlPoints_Offset),0,this);
        }
    }
    
    // Function /Script/Engine.InterpToMovementComponent:StopSimulating
    static readonly IntPtr StopSimulating_NativeFunction;
    static readonly int StopSimulating_ParamsSize;
    static readonly int StopSimulating_HitResult_Offset;
    
    public void StopSimulating(UnrealSharp.Engine.HitResult hitResult)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StopSimulating_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.HitResultMarshaler.ToNative(IntPtr.Add(ParamsBuffer, StopSimulating_HitResult_Offset), 0, null, hitResult);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StopSimulating_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.InterpToMovementComponent:RestartMovement
    static readonly IntPtr RestartMovement_NativeFunction;
    static readonly int RestartMovement_ParamsSize;
    static readonly int RestartMovement_InitialDirection_Offset;
    
    public void RestartMovement(float initialDirection = 1.000000f)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RestartMovement_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, RestartMovement_InitialDirection_Offset), 0, null, initialDirection);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RestartMovement_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.InterpToMovementComponent:ResetControlPoints
    static readonly IntPtr ResetControlPoints_NativeFunction;
    
    public void ResetControlPoints()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetControlPoints_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.InterpToMovementComponent:FinaliseControlPoints
    static readonly IntPtr FinaliseControlPoints_NativeFunction;
    
    public void FinaliseControlPoints()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FinaliseControlPoints_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.InterpToMovementComponent:AddControlPointPosition
    static readonly IntPtr AddControlPointPosition_NativeFunction;
    static readonly int AddControlPointPosition_ParamsSize;
    static readonly int AddControlPointPosition_Pos_Offset;
    static readonly int AddControlPointPosition_bPositionIsRelative_Offset;
    
    public void AddControlPointPosition(System.DoubleNumerics.Vector3 pos, bool bPositionIsRelative = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddControlPointPosition_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, AddControlPointPosition_Pos_Offset), 0, null, pos);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddControlPointPosition_bPositionIsRelative_Offset), 0, null, bPositionIsRelative);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddControlPointPosition_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}