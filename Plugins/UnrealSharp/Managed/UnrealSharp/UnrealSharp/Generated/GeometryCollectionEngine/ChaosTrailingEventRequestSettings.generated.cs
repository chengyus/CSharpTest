using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct ChaosTrailingEventRequestSettings
{
    // IntProperty /Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MaxNumberOfResults
    static readonly int MaxNumberOfResults_Offset;
    public int MaxNumberOfResults;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MinMass
    static readonly int MinMass_Offset;
    public float MinMass;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MinSpeed
    static readonly int MinSpeed_Offset;
    public float MinSpeed;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MinAngularSpeed
    static readonly int MinAngularSpeed_Offset;
    public float MinAngularSpeed;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MaxDistance
    static readonly int MaxDistance_Offset;
    public float MaxDistance;
    
    // EnumProperty /Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:SortMethod
    static readonly int SortMethod_Offset;
    public UnrealSharp.GeometryCollectionEngine.EChaosTrailingSortMethod SortMethod;
    
    
    public static readonly int NativeDataSize;
    static ChaosTrailingEventRequestSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosTrailingEventRequestSettings");
        
        MaxNumberOfResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxNumberOfResults");
        MinMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinMass");
        MinSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSpeed");
        MinAngularSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinAngularSpeed");
        MaxDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDistance");
        SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SortMethod");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosTrailingEventRequestSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxNumberOfResults = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxNumberOfResults_Offset), 0, null);
            MinMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinMass_Offset), 0, null);
            MinSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSpeed_Offset), 0, null);
            MinAngularSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinAngularSpeed_Offset), 0, null);
            MaxDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDistance_Offset), 0, null);
            SortMethod = BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosTrailingSortMethod>.FromNative(IntPtr.Add(InNativeStruct, SortMethod_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxNumberOfResults_Offset), 0, null, MaxNumberOfResults);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinMass_Offset), 0, null, MinMass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSpeed_Offset), 0, null, MinSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinAngularSpeed_Offset), 0, null, MinAngularSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDistance_Offset), 0, null, MaxDistance);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosTrailingSortMethod>.ToNative(IntPtr.Add(Buffer, SortMethod_Offset), 0, null, SortMethod);
        }
    }
}

public static class ChaosTrailingEventRequestSettingsMarshaler
{
    public static ChaosTrailingEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosTrailingEventRequestSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosTrailingEventRequestSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosTrailingEventRequestSettings.NativeDataSize;
    }
}