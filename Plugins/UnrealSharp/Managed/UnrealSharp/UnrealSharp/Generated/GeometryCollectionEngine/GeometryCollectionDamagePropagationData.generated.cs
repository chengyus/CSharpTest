using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct GeometryCollectionDamagePropagationData
{
    // BoolProperty /Script/GeometryCollectionEngine.GeometryCollectionDamagePropagationData:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // FloatProperty /Script/GeometryCollectionEngine.GeometryCollectionDamagePropagationData:BreakDamagePropagationFactor
    static readonly int BreakDamagePropagationFactor_Offset;
    public float BreakDamagePropagationFactor;
    
    // FloatProperty /Script/GeometryCollectionEngine.GeometryCollectionDamagePropagationData:ShockDamagePropagationFactor
    static readonly int ShockDamagePropagationFactor_Offset;
    public float ShockDamagePropagationFactor;
    
    
    public static readonly int NativeDataSize;
    static GeometryCollectionDamagePropagationData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("GeometryCollectionDamagePropagationData");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        BreakDamagePropagationFactor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BreakDamagePropagationFactor");
        ShockDamagePropagationFactor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShockDamagePropagationFactor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public GeometryCollectionDamagePropagationData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            BreakDamagePropagationFactor = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BreakDamagePropagationFactor_Offset), 0, null);
            ShockDamagePropagationFactor = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ShockDamagePropagationFactor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BreakDamagePropagationFactor_Offset), 0, null, BreakDamagePropagationFactor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ShockDamagePropagationFactor_Offset), 0, null, ShockDamagePropagationFactor);
        }
    }
}

public static class GeometryCollectionDamagePropagationDataMarshaler
{
    public static GeometryCollectionDamagePropagationData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new GeometryCollectionDamagePropagationData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, GeometryCollectionDamagePropagationData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return GeometryCollectionDamagePropagationData.NativeDataSize;
    }
}