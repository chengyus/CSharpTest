using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SubtitleCue
{
    // FloatProperty /Script/Engine.SubtitleCue:Time
    static readonly int Time_Offset;
    public float Time;
    
    
    public static readonly int NativeDataSize;
    static SubtitleCue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubtitleCue");
        
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubtitleCue(IntPtr InNativeStruct)
    {
        unsafe
        {
            Time = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Time_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Time_Offset), 0, null, Time);
        }
    }
}

public static class SubtitleCueMarshaler
{
    public static SubtitleCue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubtitleCue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubtitleCue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubtitleCue.NativeDataSize;
    }
}