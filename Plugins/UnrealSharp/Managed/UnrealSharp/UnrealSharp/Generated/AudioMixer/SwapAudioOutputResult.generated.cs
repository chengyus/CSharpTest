using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UStruct]
public partial struct SwapAudioOutputResult
{
    // EnumProperty /Script/AudioMixer.SwapAudioOutputResult:Result
    static readonly int Result_Offset;
    public UnrealSharp.AudioMixer.ESwapAudioOutputDeviceResultState Result;
    
    
    public static readonly int NativeDataSize;
    static SwapAudioOutputResult()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SwapAudioOutputResult");
        
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SwapAudioOutputResult(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = BlittableMarshaller<UnrealSharp.AudioMixer.ESwapAudioOutputDeviceResultState>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AudioMixer.ESwapAudioOutputDeviceResultState>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class SwapAudioOutputResultMarshaler
{
    public static SwapAudioOutputResult FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SwapAudioOutputResult(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SwapAudioOutputResult obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SwapAudioOutputResult.NativeDataSize;
    }
}