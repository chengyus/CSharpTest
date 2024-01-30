using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UStruct]
public partial struct VOscillator
{
    // StructProperty /Script/GameplayCameras.VOscillator:X
    static readonly int X_Offset;
    public UnrealSharp.GameplayCameras.FOscillator X;
    
    // StructProperty /Script/GameplayCameras.VOscillator:Y
    static readonly int Y_Offset;
    public UnrealSharp.GameplayCameras.FOscillator Y;
    
    // StructProperty /Script/GameplayCameras.VOscillator:Z
    static readonly int Z_Offset;
    public UnrealSharp.GameplayCameras.FOscillator Z;
    
    
    public static readonly int NativeDataSize;
    static VOscillator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("VOscillator");
        
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        Z_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Z");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public VOscillator(IntPtr InNativeStruct)
    {
        unsafe
        {
            X = UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(InNativeStruct, X_Offset), 0, null);
            Y = UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(InNativeStruct, Y_Offset), 0, null);
            Z = UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(InNativeStruct, Z_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(Buffer, X_Offset), 0, null, X);
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(Buffer, Y_Offset), 0, null, Y);
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(Buffer, Z_Offset), 0, null, Z);
        }
    }
}

public static class VOscillatorMarshaler
{
    public static VOscillator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new VOscillator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, VOscillator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return VOscillator.NativeDataSize;
    }
}