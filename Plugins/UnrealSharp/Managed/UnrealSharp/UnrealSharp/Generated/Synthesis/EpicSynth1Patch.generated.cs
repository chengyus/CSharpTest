using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct EpicSynth1Patch
{
    // EnumProperty /Script/Synthesis.EpicSynth1Patch:PatchSource
    static readonly int PatchSource_Offset;
    public UnrealSharp.Synthesis.ESynth1PatchSource PatchSource;
    
    
    public static readonly int NativeDataSize;
    static EpicSynth1Patch()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EpicSynth1Patch");
        
        PatchSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PatchSource");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EpicSynth1Patch(IntPtr InNativeStruct)
    {
        unsafe
        {
            PatchSource = BlittableMarshaller<UnrealSharp.Synthesis.ESynth1PatchSource>.FromNative(IntPtr.Add(InNativeStruct, PatchSource_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESynth1PatchSource>.ToNative(IntPtr.Add(Buffer, PatchSource_Offset), 0, null, PatchSource);
        }
    }
}

public static class EpicSynth1PatchMarshaler
{
    public static EpicSynth1Patch FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EpicSynth1Patch(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EpicSynth1Patch obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EpicSynth1Patch.NativeDataSize;
    }
}