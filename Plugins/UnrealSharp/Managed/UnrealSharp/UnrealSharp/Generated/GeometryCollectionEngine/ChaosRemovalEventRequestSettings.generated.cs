using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct ChaosRemovalEventRequestSettings
{
    // IntProperty /Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:MaxNumberOfResults
    static readonly int MaxNumberOfResults_Offset;
    public int MaxNumberOfResults;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:MinMass
    static readonly int MinMass_Offset;
    public float MinMass;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:MaxDistance
    static readonly int MaxDistance_Offset;
    public float MaxDistance;
    
    // EnumProperty /Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:SortMethod
    static readonly int SortMethod_Offset;
    public UnrealSharp.GeometryCollectionEngine.EChaosRemovalSortMethod SortMethod;
    
    
    public static readonly int NativeDataSize;
    static ChaosRemovalEventRequestSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosRemovalEventRequestSettings");
        
        MaxNumberOfResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxNumberOfResults");
        MinMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinMass");
        MaxDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDistance");
        SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SortMethod");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosRemovalEventRequestSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxNumberOfResults = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxNumberOfResults_Offset), 0, null);
            MinMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinMass_Offset), 0, null);
            MaxDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDistance_Offset), 0, null);
            SortMethod = BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosRemovalSortMethod>.FromNative(IntPtr.Add(InNativeStruct, SortMethod_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxNumberOfResults_Offset), 0, null, MaxNumberOfResults);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinMass_Offset), 0, null, MinMass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDistance_Offset), 0, null, MaxDistance);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosRemovalSortMethod>.ToNative(IntPtr.Add(Buffer, SortMethod_Offset), 0, null, SortMethod);
        }
    }
}

public static class ChaosRemovalEventRequestSettingsMarshaler
{
    public static ChaosRemovalEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosRemovalEventRequestSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosRemovalEventRequestSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosRemovalEventRequestSettings.NativeDataSize;
    }
}