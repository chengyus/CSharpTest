using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct ChaosBreakingEventRequestSettings
{
    // IntProperty /Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MaxNumberOfResults
    static readonly int MaxNumberOfResults_Offset;
    public int MaxNumberOfResults;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MinRadius
    static readonly int MinRadius_Offset;
    public float MinRadius;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MinSpeed
    static readonly int MinSpeed_Offset;
    public float MinSpeed;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MinMass
    static readonly int MinMass_Offset;
    public float MinMass;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MaxDistance
    static readonly int MaxDistance_Offset;
    public float MaxDistance;
    
    // EnumProperty /Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:SortMethod
    static readonly int SortMethod_Offset;
    public UnrealSharp.GeometryCollectionEngine.EChaosBreakingSortMethod SortMethod;
    
    
    public static readonly int NativeDataSize;
    static ChaosBreakingEventRequestSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosBreakingEventRequestSettings");
        
        MaxNumberOfResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxNumberOfResults");
        MinRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinRadius");
        MinSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSpeed");
        MinMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinMass");
        MaxDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDistance");
        SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SortMethod");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosBreakingEventRequestSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxNumberOfResults = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxNumberOfResults_Offset), 0, null);
            MinRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinRadius_Offset), 0, null);
            MinSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSpeed_Offset), 0, null);
            MinMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinMass_Offset), 0, null);
            MaxDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDistance_Offset), 0, null);
            SortMethod = BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosBreakingSortMethod>.FromNative(IntPtr.Add(InNativeStruct, SortMethod_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxNumberOfResults_Offset), 0, null, MaxNumberOfResults);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinRadius_Offset), 0, null, MinRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSpeed_Offset), 0, null, MinSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinMass_Offset), 0, null, MinMass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDistance_Offset), 0, null, MaxDistance);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosBreakingSortMethod>.ToNative(IntPtr.Add(Buffer, SortMethod_Offset), 0, null, SortMethod);
        }
    }
}

public static class ChaosBreakingEventRequestSettingsMarshaler
{
    public static ChaosBreakingEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosBreakingEventRequestSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosBreakingEventRequestSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosBreakingEventRequestSettings.NativeDataSize;
    }
}