using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct Timecode
{
    // IntProperty /Script/CoreUObject.Timecode:Hours
    static readonly int Hours_Offset;
    public int Hours;
    
    // IntProperty /Script/CoreUObject.Timecode:Minutes
    static readonly int Minutes_Offset;
    public int Minutes;
    
    // IntProperty /Script/CoreUObject.Timecode:Seconds
    static readonly int Seconds_Offset;
    public int Seconds;
    
    // IntProperty /Script/CoreUObject.Timecode:Frames
    static readonly int Frames_Offset;
    public int Frames;
    
    // BoolProperty /Script/CoreUObject.Timecode:bDropFrameFormat
    static readonly int bDropFrameFormat_Offset;
    public bool DropFrameFormat;
    
    
    public static readonly int NativeDataSize;
    static Timecode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Timecode");
        
        Hours_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Hours");
        Minutes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minutes");
        Seconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Seconds");
        Frames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frames");
        bDropFrameFormat_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDropFrameFormat");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Timecode(IntPtr InNativeStruct)
    {
        unsafe
        {
            Hours = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Hours_Offset), 0, null);
            Minutes = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Minutes_Offset), 0, null);
            Seconds = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Seconds_Offset), 0, null);
            Frames = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Frames_Offset), 0, null);
            DropFrameFormat = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDropFrameFormat_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Hours_Offset), 0, null, Hours);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Minutes_Offset), 0, null, Minutes);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Seconds_Offset), 0, null, Seconds);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Frames_Offset), 0, null, Frames);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDropFrameFormat_Offset), 0, null, DropFrameFormat);
        }
    }
}

public static class TimecodeMarshaler
{
    public static Timecode FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Timecode(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Timecode obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Timecode.NativeDataSize;
    }
}