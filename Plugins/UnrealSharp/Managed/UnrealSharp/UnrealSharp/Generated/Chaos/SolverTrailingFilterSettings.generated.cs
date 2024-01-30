using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UStruct]
public partial struct SolverTrailingFilterSettings
{
    // BoolProperty /Script/Chaos.SolverTrailingFilterSettings:FilterEnabled
    static readonly int FilterEnabled_Offset;
    public bool FilterEnabled;
    
    // FloatProperty /Script/Chaos.SolverTrailingFilterSettings:MinMass
    static readonly int MinMass_Offset;
    public float MinMass;
    
    // FloatProperty /Script/Chaos.SolverTrailingFilterSettings:MinSpeed
    static readonly int MinSpeed_Offset;
    public float MinSpeed;
    
    // FloatProperty /Script/Chaos.SolverTrailingFilterSettings:MinVolume
    static readonly int MinVolume_Offset;
    public float MinVolume;
    
    
    public static readonly int NativeDataSize;
    static SolverTrailingFilterSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SolverTrailingFilterSettings");
        
        FilterEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterEnabled");
        MinMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinMass");
        MinSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSpeed");
        MinVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinVolume");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SolverTrailingFilterSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FilterEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, FilterEnabled_Offset), 0, null);
            MinMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinMass_Offset), 0, null);
            MinSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSpeed_Offset), 0, null);
            MinVolume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinVolume_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, FilterEnabled_Offset), 0, null, FilterEnabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinMass_Offset), 0, null, MinMass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSpeed_Offset), 0, null, MinSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinVolume_Offset), 0, null, MinVolume);
        }
    }
}

public static class SolverTrailingFilterSettingsMarshaler
{
    public static SolverTrailingFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SolverTrailingFilterSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SolverTrailingFilterSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SolverTrailingFilterSettings.NativeDataSize;
    }
}