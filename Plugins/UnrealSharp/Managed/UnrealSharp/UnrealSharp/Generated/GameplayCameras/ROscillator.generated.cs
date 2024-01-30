using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UStruct]
public partial struct ROscillator
{
    // StructProperty /Script/GameplayCameras.ROscillator:Pitch
    static readonly int Pitch_Offset;
    public UnrealSharp.GameplayCameras.FOscillator Pitch;
    
    // StructProperty /Script/GameplayCameras.ROscillator:Yaw
    static readonly int Yaw_Offset;
    public UnrealSharp.GameplayCameras.FOscillator Yaw;
    
    // StructProperty /Script/GameplayCameras.ROscillator:Roll
    static readonly int Roll_Offset;
    public UnrealSharp.GameplayCameras.FOscillator Roll;
    
    
    public static readonly int NativeDataSize;
    static ROscillator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ROscillator");
        
        Pitch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pitch");
        Yaw_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Yaw");
        Roll_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Roll");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ROscillator(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pitch = UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pitch_Offset), 0, null);
            Yaw = UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(InNativeStruct, Yaw_Offset), 0, null);
            Roll = UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(InNativeStruct, Roll_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(Buffer, Pitch_Offset), 0, null, Pitch);
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(Buffer, Yaw_Offset), 0, null, Yaw);
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(Buffer, Roll_Offset), 0, null, Roll);
        }
    }
}

public static class ROscillatorMarshaler
{
    public static ROscillator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ROscillator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ROscillator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ROscillator.NativeDataSize;
    }
}