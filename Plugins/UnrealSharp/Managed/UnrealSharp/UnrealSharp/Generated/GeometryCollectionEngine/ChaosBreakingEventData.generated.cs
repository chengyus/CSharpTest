using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct ChaosBreakingEventData
{
    // StructProperty /Script/GeometryCollectionEngine.ChaosBreakingEventData:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosBreakingEventData:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosBreakingEventData:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    
    public static readonly int NativeDataSize;
    static ChaosBreakingEventData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosBreakingEventData");
        
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosBreakingEventData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
        }
    }
}

public static class ChaosBreakingEventDataMarshaler
{
    public static ChaosBreakingEventData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosBreakingEventData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosBreakingEventData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosBreakingEventData.NativeDataSize;
    }
}