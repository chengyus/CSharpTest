using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundWaveCuePoint
{
    // IntProperty /Script/Engine.SoundWaveCuePoint:CuePointID
    static readonly int CuePointID_Offset;
    public int CuePointID;
    
    // IntProperty /Script/Engine.SoundWaveCuePoint:FramePosition
    static readonly int FramePosition_Offset;
    public int FramePosition;
    
    // IntProperty /Script/Engine.SoundWaveCuePoint:FrameLength
    static readonly int FrameLength_Offset;
    public int FrameLength;
    
    
    public static readonly int NativeDataSize;
    static SoundWaveCuePoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundWaveCuePoint");
        
        CuePointID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CuePointID");
        FramePosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FramePosition");
        FrameLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameLength");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundWaveCuePoint(IntPtr InNativeStruct)
    {
        unsafe
        {
            CuePointID = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, CuePointID_Offset), 0, null);
            FramePosition = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FramePosition_Offset), 0, null);
            FrameLength = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FrameLength_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, CuePointID_Offset), 0, null, CuePointID);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FramePosition_Offset), 0, null, FramePosition);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FrameLength_Offset), 0, null, FrameLength);
        }
    }
}

public static class SoundWaveCuePointMarshaler
{
    public static SoundWaveCuePoint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundWaveCuePoint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundWaveCuePoint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundWaveCuePoint.NativeDataSize;
    }
}