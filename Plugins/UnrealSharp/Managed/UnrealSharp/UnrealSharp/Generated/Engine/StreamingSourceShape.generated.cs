using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct StreamingSourceShape
{
    // BoolProperty /Script/Engine.StreamingSourceShape:bUseGridLoadingRange
    static readonly int bUseGridLoadingRange_Offset;
    public bool UseGridLoadingRange;
    
    // FloatProperty /Script/Engine.StreamingSourceShape:LoadingRangeScale
    static readonly int LoadingRangeScale_Offset;
    public float LoadingRangeScale;
    
    // FloatProperty /Script/Engine.StreamingSourceShape:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    // BoolProperty /Script/Engine.StreamingSourceShape:bIsSector
    static readonly int bIsSector_Offset;
    public bool IsSector;
    
    // FloatProperty /Script/Engine.StreamingSourceShape:SectorAngle
    static readonly int SectorAngle_Offset;
    public float SectorAngle;
    
    // StructProperty /Script/Engine.StreamingSourceShape:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.StreamingSourceShape:Rotation
    static readonly int Rotation_Offset;
    public UnrealSharp.Rotator Rotation;
    
    
    public static readonly int NativeDataSize;
    static StreamingSourceShape()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("StreamingSourceShape");
        
        bUseGridLoadingRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseGridLoadingRange");
        LoadingRangeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LoadingRangeScale");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        bIsSector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSector");
        SectorAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SectorAngle");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public StreamingSourceShape(IntPtr InNativeStruct)
    {
        unsafe
        {
            UseGridLoadingRange = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseGridLoadingRange_Offset), 0, null);
            LoadingRangeScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LoadingRangeScale_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
            IsSector = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSector_Offset), 0, null);
            SectorAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SectorAngle_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Rotation = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseGridLoadingRange_Offset), 0, null, UseGridLoadingRange);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LoadingRangeScale_Offset), 0, null, LoadingRangeScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSector_Offset), 0, null, IsSector);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SectorAngle_Offset), 0, null, SectorAngle);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
        }
    }
}

public static class StreamingSourceShapeMarshaler
{
    public static StreamingSourceShape FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new StreamingSourceShape(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, StreamingSourceShape obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return StreamingSourceShape.NativeDataSize;
    }
}