using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigCurrentAndInitialTransform
{
    // StructProperty /Script/ControlRig.RigCurrentAndInitialTransform:Current
    static readonly int Current_Offset;
    public UnrealSharp.ControlRig.RigLocalAndGlobalTransform Current;
    
    // StructProperty /Script/ControlRig.RigCurrentAndInitialTransform:Initial
    static readonly int Initial_Offset;
    public UnrealSharp.ControlRig.RigLocalAndGlobalTransform Initial;
    
    
    public static readonly int NativeDataSize;
    static RigCurrentAndInitialTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigCurrentAndInitialTransform");
        
        Current_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Current");
        Initial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Initial");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigCurrentAndInitialTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Current = UnrealSharp.ControlRig.RigLocalAndGlobalTransformMarshaler.FromNative(IntPtr.Add(InNativeStruct, Current_Offset), 0, null);
            Initial = UnrealSharp.ControlRig.RigLocalAndGlobalTransformMarshaler.FromNative(IntPtr.Add(InNativeStruct, Initial_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigLocalAndGlobalTransformMarshaler.ToNative(IntPtr.Add(Buffer, Current_Offset), 0, null, Current);
            UnrealSharp.ControlRig.RigLocalAndGlobalTransformMarshaler.ToNative(IntPtr.Add(Buffer, Initial_Offset), 0, null, Initial);
        }
    }
}

public static class RigCurrentAndInitialTransformMarshaler
{
    public static RigCurrentAndInitialTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigCurrentAndInitialTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigCurrentAndInitialTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigCurrentAndInitialTransform.NativeDataSize;
    }
}