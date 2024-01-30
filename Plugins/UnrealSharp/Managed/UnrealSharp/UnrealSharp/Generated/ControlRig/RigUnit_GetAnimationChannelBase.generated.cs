using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetAnimationChannelBase
{
    // NameProperty /Script/ControlRig.RigUnit_GetAnimationChannelBase:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // NameProperty /Script/ControlRig.RigUnit_GetAnimationChannelBase:Channel
    static readonly int Channel_Offset;
    public Name Channel;
    
    // BoolProperty /Script/ControlRig.RigUnit_GetAnimationChannelBase:bInitial
    static readonly int bInitial_Offset;
    public bool Initial;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetAnimationChannelBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetAnimationChannelBase");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Channel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Channel");
        bInitial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInitial");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetAnimationChannelBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Channel = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Channel_Offset), 0, null);
            Initial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bInitial_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Channel_Offset), 0, null, Channel);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bInitial_Offset), 0, null, Initial);
        }
    }
}

public static class RigUnit_GetAnimationChannelBaseMarshaler
{
    public static RigUnit_GetAnimationChannelBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetAnimationChannelBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetAnimationChannelBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetAnimationChannelBase.NativeDataSize;
    }
}