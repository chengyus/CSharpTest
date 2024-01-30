using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PredictProjectilePathParams
{
    // StructProperty /Script/Engine.PredictProjectilePathParams:StartLocation
    static readonly int StartLocation_Offset;
    public System.DoubleNumerics.Vector3 StartLocation;
    
    // StructProperty /Script/Engine.PredictProjectilePathParams:LaunchVelocity
    static readonly int LaunchVelocity_Offset;
    public System.DoubleNumerics.Vector3 LaunchVelocity;
    
    // BoolProperty /Script/Engine.PredictProjectilePathParams:bTraceWithCollision
    static readonly int bTraceWithCollision_Offset;
    public bool TraceWithCollision;
    
    // FloatProperty /Script/Engine.PredictProjectilePathParams:ProjectileRadius
    static readonly int ProjectileRadius_Offset;
    public float ProjectileRadius;
    
    // FloatProperty /Script/Engine.PredictProjectilePathParams:MaxSimTime
    static readonly int MaxSimTime_Offset;
    public float MaxSimTime;
    
    // BoolProperty /Script/Engine.PredictProjectilePathParams:bTraceWithChannel
    static readonly int bTraceWithChannel_Offset;
    public bool TraceWithChannel;
    
    // ByteProperty /Script/Engine.PredictProjectilePathParams:TraceChannel
    static readonly int TraceChannel_Offset;
    public UnrealSharp.Engine.ECollisionChannel TraceChannel;
    
    // FloatProperty /Script/Engine.PredictProjectilePathParams:SimFrequency
    static readonly int SimFrequency_Offset;
    public float SimFrequency;
    
    // FloatProperty /Script/Engine.PredictProjectilePathParams:OverrideGravityZ
    static readonly int OverrideGravityZ_Offset;
    public float OverrideGravityZ;
    
    // ByteProperty /Script/Engine.PredictProjectilePathParams:DrawDebugType
    static readonly int DrawDebugType_Offset;
    public UnrealSharp.Engine.EDrawDebugTrace DrawDebugType;
    
    // FloatProperty /Script/Engine.PredictProjectilePathParams:DrawDebugTime
    static readonly int DrawDebugTime_Offset;
    public float DrawDebugTime;
    
    // BoolProperty /Script/Engine.PredictProjectilePathParams:bTraceComplex
    static readonly int bTraceComplex_Offset;
    public bool TraceComplex;
    
    
    public static readonly int NativeDataSize;
    static PredictProjectilePathParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PredictProjectilePathParams");
        
        StartLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartLocation");
        LaunchVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LaunchVelocity");
        bTraceWithCollision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTraceWithCollision");
        ProjectileRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProjectileRadius");
        MaxSimTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSimTime");
        bTraceWithChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTraceWithChannel");
        TraceChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TraceChannel");
        SimFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SimFrequency");
        OverrideGravityZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverrideGravityZ");
        DrawDebugType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DrawDebugType");
        DrawDebugTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DrawDebugTime");
        bTraceComplex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTraceComplex");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PredictProjectilePathParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, StartLocation_Offset), 0, null);
            LaunchVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, LaunchVelocity_Offset), 0, null);
            TraceWithCollision = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTraceWithCollision_Offset), 0, null);
            ProjectileRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ProjectileRadius_Offset), 0, null);
            MaxSimTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxSimTime_Offset), 0, null);
            TraceWithChannel = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTraceWithChannel_Offset), 0, null);
            TraceChannel = BlittableMarshaller<UnrealSharp.Engine.ECollisionChannel>.FromNative(IntPtr.Add(InNativeStruct, TraceChannel_Offset), 0, null);
            SimFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SimFrequency_Offset), 0, null);
            OverrideGravityZ = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OverrideGravityZ_Offset), 0, null);
            DrawDebugType = BlittableMarshaller<UnrealSharp.Engine.EDrawDebugTrace>.FromNative(IntPtr.Add(InNativeStruct, DrawDebugType_Offset), 0, null);
            DrawDebugTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DrawDebugTime_Offset), 0, null);
            TraceComplex = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTraceComplex_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, StartLocation_Offset), 0, null, StartLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, LaunchVelocity_Offset), 0, null, LaunchVelocity);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTraceWithCollision_Offset), 0, null, TraceWithCollision);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ProjectileRadius_Offset), 0, null, ProjectileRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxSimTime_Offset), 0, null, MaxSimTime);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTraceWithChannel_Offset), 0, null, TraceWithChannel);
            BlittableMarshaller<UnrealSharp.Engine.ECollisionChannel>.ToNative(IntPtr.Add(Buffer, TraceChannel_Offset), 0, null, TraceChannel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SimFrequency_Offset), 0, null, SimFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OverrideGravityZ_Offset), 0, null, OverrideGravityZ);
            BlittableMarshaller<UnrealSharp.Engine.EDrawDebugTrace>.ToNative(IntPtr.Add(Buffer, DrawDebugType_Offset), 0, null, DrawDebugType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DrawDebugTime_Offset), 0, null, DrawDebugTime);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTraceComplex_Offset), 0, null, TraceComplex);
        }
    }
}

public static class PredictProjectilePathParamsMarshaler
{
    public static PredictProjectilePathParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PredictProjectilePathParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PredictProjectilePathParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PredictProjectilePathParams.NativeDataSize;
    }
}