using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct WorldPartitionStreamingQuerySource
{
    // StructProperty /Script/Engine.WorldPartitionStreamingQuerySource:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // FloatProperty /Script/Engine.WorldPartitionStreamingQuerySource:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    // BoolProperty /Script/Engine.WorldPartitionStreamingQuerySource:bUseGridLoadingRange
    static readonly int bUseGridLoadingRange_Offset;
    public bool UseGridLoadingRange;
    
    // BoolProperty /Script/Engine.WorldPartitionStreamingQuerySource:bDataLayersOnly
    static readonly int bDataLayersOnly_Offset;
    public bool DataLayersOnly;
    
    // BoolProperty /Script/Engine.WorldPartitionStreamingQuerySource:bSpatialQuery
    static readonly int bSpatialQuery_Offset;
    public bool SpatialQuery;
    
    
    public static readonly int NativeDataSize;
    static WorldPartitionStreamingQuerySource()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WorldPartitionStreamingQuerySource");
        
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        bUseGridLoadingRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseGridLoadingRange");
        bDataLayersOnly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDataLayersOnly");
        bSpatialQuery_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpatialQuery");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WorldPartitionStreamingQuerySource(IntPtr InNativeStruct)
    {
        unsafe
        {
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
            UseGridLoadingRange = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseGridLoadingRange_Offset), 0, null);
            DataLayersOnly = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDataLayersOnly_Offset), 0, null);
            SpatialQuery = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSpatialQuery_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseGridLoadingRange_Offset), 0, null, UseGridLoadingRange);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDataLayersOnly_Offset), 0, null, DataLayersOnly);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSpatialQuery_Offset), 0, null, SpatialQuery);
        }
    }
}

public static class WorldPartitionStreamingQuerySourceMarshaler
{
    public static WorldPartitionStreamingQuerySource FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WorldPartitionStreamingQuerySource(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WorldPartitionStreamingQuerySource obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WorldPartitionStreamingQuerySource.NativeDataSize;
    }
}