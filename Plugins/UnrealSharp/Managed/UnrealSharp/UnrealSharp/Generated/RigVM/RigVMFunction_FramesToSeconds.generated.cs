using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_FramesToSeconds
{
    // FloatProperty /Script/RigVM.RigVMFunction_FramesToSeconds:Frames
    static readonly int Frames_Offset;
    public float Frames;
    
    // FloatProperty /Script/RigVM.RigVMFunction_FramesToSeconds:Seconds
    static readonly int Seconds_Offset;
    public float Seconds;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_FramesToSeconds()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_FramesToSeconds");
        
        Frames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frames");
        Seconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Seconds");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_FramesToSeconds(IntPtr InNativeStruct)
    {
        unsafe
        {
            Frames = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frames_Offset), 0, null);
            Seconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Seconds_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frames_Offset), 0, null, Frames);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Seconds_Offset), 0, null, Seconds);
        }
    }
}

public static class RigVMFunction_FramesToSecondsMarshaler
{
    public static RigVMFunction_FramesToSeconds FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_FramesToSeconds(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_FramesToSeconds obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_FramesToSeconds.NativeDataSize;
    }
}