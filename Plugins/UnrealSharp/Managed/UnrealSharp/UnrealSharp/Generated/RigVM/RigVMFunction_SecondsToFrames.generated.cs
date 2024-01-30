using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_SecondsToFrames
{
    // FloatProperty /Script/RigVM.RigVMFunction_SecondsToFrames:Seconds
    static readonly int Seconds_Offset;
    public float Seconds;
    
    // FloatProperty /Script/RigVM.RigVMFunction_SecondsToFrames:Frames
    static readonly int Frames_Offset;
    public float Frames;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_SecondsToFrames()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_SecondsToFrames");
        
        Seconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Seconds");
        Frames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frames");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_SecondsToFrames(IntPtr InNativeStruct)
    {
        unsafe
        {
            Seconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Seconds_Offset), 0, null);
            Frames = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frames_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Seconds_Offset), 0, null, Seconds);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frames_Offset), 0, null, Frames);
        }
    }
}

public static class RigVMFunction_SecondsToFramesMarshaler
{
    public static RigVMFunction_SecondsToFrames FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_SecondsToFrames(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_SecondsToFrames obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_SecondsToFrames.NativeDataSize;
    }
}