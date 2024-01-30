using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PredictProjectilePathPointData
{
    // StructProperty /Script/Engine.PredictProjectilePathPointData:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.PredictProjectilePathPointData:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    // FloatProperty /Script/Engine.PredictProjectilePathPointData:Time
    static readonly int Time_Offset;
    public float Time;
    
    
    public static readonly int NativeDataSize;
    static PredictProjectilePathPointData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PredictProjectilePathPointData");
        
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PredictProjectilePathPointData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
            Time = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Time_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Time_Offset), 0, null, Time);
        }
    }
}

public static class PredictProjectilePathPointDataMarshaler
{
    public static PredictProjectilePathPointData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PredictProjectilePathPointData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PredictProjectilePathPointData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PredictProjectilePathPointData.NativeDataSize;
    }
}