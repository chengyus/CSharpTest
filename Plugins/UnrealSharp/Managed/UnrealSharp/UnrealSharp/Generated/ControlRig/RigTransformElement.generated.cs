using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigTransformElement
{
    // StructProperty /Script/ControlRig.RigTransformElement:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigCurrentAndInitialTransform Pose;
    
    
    public static readonly int NativeDataSize;
    static RigTransformElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigTransformElement");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigTransformElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigCurrentAndInitialTransformMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigCurrentAndInitialTransformMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
        }
    }
}

public static class RigTransformElementMarshaler
{
    public static RigTransformElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigTransformElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigTransformElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigTransformElement.NativeDataSize;
    }
}