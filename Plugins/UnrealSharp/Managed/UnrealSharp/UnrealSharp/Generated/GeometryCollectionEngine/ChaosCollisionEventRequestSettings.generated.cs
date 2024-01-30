using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct ChaosCollisionEventRequestSettings
{
    // IntProperty /Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MaxNumberResults
    static readonly int MaxNumberResults_Offset;
    public int MaxNumberResults;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MinMass
    static readonly int MinMass_Offset;
    public float MinMass;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MinSpeed
    static readonly int MinSpeed_Offset;
    public float MinSpeed;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MinImpulse
    static readonly int MinImpulse_Offset;
    public float MinImpulse;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MaxDistance
    static readonly int MaxDistance_Offset;
    public float MaxDistance;
    
    // EnumProperty /Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:SortMethod
    static readonly int SortMethod_Offset;
    public UnrealSharp.GeometryCollectionEngine.EChaosCollisionSortMethod SortMethod;
    
    
    public static readonly int NativeDataSize;
    static ChaosCollisionEventRequestSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosCollisionEventRequestSettings");
        
        MaxNumberResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxNumberResults");
        MinMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinMass");
        MinSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSpeed");
        MinImpulse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinImpulse");
        MaxDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDistance");
        SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SortMethod");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosCollisionEventRequestSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxNumberResults = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxNumberResults_Offset), 0, null);
            MinMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinMass_Offset), 0, null);
            MinSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSpeed_Offset), 0, null);
            MinImpulse = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinImpulse_Offset), 0, null);
            MaxDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDistance_Offset), 0, null);
            SortMethod = BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosCollisionSortMethod>.FromNative(IntPtr.Add(InNativeStruct, SortMethod_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxNumberResults_Offset), 0, null, MaxNumberResults);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinMass_Offset), 0, null, MinMass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSpeed_Offset), 0, null, MinSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinImpulse_Offset), 0, null, MinImpulse);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDistance_Offset), 0, null, MaxDistance);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosCollisionSortMethod>.ToNative(IntPtr.Add(Buffer, SortMethod_Offset), 0, null, SortMethod);
        }
    }
}

public static class ChaosCollisionEventRequestSettingsMarshaler
{
    public static ChaosCollisionEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosCollisionEventRequestSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosCollisionEventRequestSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosCollisionEventRequestSettings.NativeDataSize;
    }
}