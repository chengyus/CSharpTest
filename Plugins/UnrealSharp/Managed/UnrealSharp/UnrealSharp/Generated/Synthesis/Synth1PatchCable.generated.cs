using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct Synth1PatchCable
{
    // FloatProperty /Script/Synthesis.Synth1PatchCable:Depth
    static readonly int Depth_Offset;
    public float Depth;
    
    // EnumProperty /Script/Synthesis.Synth1PatchCable:Destination
    static readonly int Destination_Offset;
    public UnrealSharp.Synthesis.ESynth1PatchDestination Destination;
    
    
    public static readonly int NativeDataSize;
    static Synth1PatchCable()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Synth1PatchCable");
        
        Depth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Depth");
        Destination_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Destination");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Synth1PatchCable(IntPtr InNativeStruct)
    {
        unsafe
        {
            Depth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Depth_Offset), 0, null);
            Destination = BlittableMarshaller<UnrealSharp.Synthesis.ESynth1PatchDestination>.FromNative(IntPtr.Add(InNativeStruct, Destination_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Depth_Offset), 0, null, Depth);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynth1PatchDestination>.ToNative(IntPtr.Add(Buffer, Destination_Offset), 0, null, Destination);
        }
    }
}

public static class Synth1PatchCableMarshaler
{
    public static Synth1PatchCable FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Synth1PatchCable(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Synth1PatchCable obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Synth1PatchCable.NativeDataSize;
    }
}