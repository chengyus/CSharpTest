using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UStruct]
public partial struct SolverCollisionFilterSettings
{
    // BoolProperty /Script/Chaos.SolverCollisionFilterSettings:FilterEnabled
    static readonly int FilterEnabled_Offset;
    public bool FilterEnabled;
    
    // FloatProperty /Script/Chaos.SolverCollisionFilterSettings:MinMass
    static readonly int MinMass_Offset;
    public float MinMass;
    
    // FloatProperty /Script/Chaos.SolverCollisionFilterSettings:MinSpeed
    static readonly int MinSpeed_Offset;
    public float MinSpeed;
    
    // FloatProperty /Script/Chaos.SolverCollisionFilterSettings:MinImpulse
    static readonly int MinImpulse_Offset;
    public float MinImpulse;
    
    
    public static readonly int NativeDataSize;
    static SolverCollisionFilterSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SolverCollisionFilterSettings");
        
        FilterEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterEnabled");
        MinMass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinMass");
        MinSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSpeed");
        MinImpulse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinImpulse");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SolverCollisionFilterSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FilterEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, FilterEnabled_Offset), 0, null);
            MinMass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinMass_Offset), 0, null);
            MinSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSpeed_Offset), 0, null);
            MinImpulse = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinImpulse_Offset), 0, null);
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
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinImpulse_Offset), 0, null, MinImpulse);
        }
    }
}

public static class SolverCollisionFilterSettingsMarshaler
{
    public static SolverCollisionFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SolverCollisionFilterSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SolverCollisionFilterSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SolverCollisionFilterSettings.NativeDataSize;
    }
}