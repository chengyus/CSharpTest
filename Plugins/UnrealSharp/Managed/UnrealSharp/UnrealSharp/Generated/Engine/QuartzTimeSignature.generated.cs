using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct QuartzTimeSignature
{
    // IntProperty /Script/Engine.QuartzTimeSignature:NumBeats
    static readonly int NumBeats_Offset;
    public int NumBeats;
    
    // EnumProperty /Script/Engine.QuartzTimeSignature:BeatType
    static readonly int BeatType_Offset;
    public UnrealSharp.Engine.EQuartzTimeSignatureQuantization BeatType;
    
    
    public static readonly int NativeDataSize;
    static QuartzTimeSignature()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("QuartzTimeSignature");
        
        NumBeats_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumBeats");
        BeatType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BeatType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public QuartzTimeSignature(IntPtr InNativeStruct)
    {
        unsafe
        {
            NumBeats = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumBeats_Offset), 0, null);
            BeatType = BlittableMarshaller<UnrealSharp.Engine.EQuartzTimeSignatureQuantization>.FromNative(IntPtr.Add(InNativeStruct, BeatType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumBeats_Offset), 0, null, NumBeats);
            BlittableMarshaller<UnrealSharp.Engine.EQuartzTimeSignatureQuantization>.ToNative(IntPtr.Add(Buffer, BeatType_Offset), 0, null, BeatType);
        }
    }
}

public static class QuartzTimeSignatureMarshaler
{
    public static QuartzTimeSignature FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new QuartzTimeSignature(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, QuartzTimeSignature obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return QuartzTimeSignature.NativeDataSize;
    }
}