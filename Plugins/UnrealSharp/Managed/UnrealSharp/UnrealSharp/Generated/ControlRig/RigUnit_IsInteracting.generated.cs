using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_IsInteracting
{
    // BoolProperty /Script/ControlRig.RigUnit_IsInteracting:bIsInteracting
    static readonly int bIsInteracting_Offset;
    public bool IsInteracting;
    
    // BoolProperty /Script/ControlRig.RigUnit_IsInteracting:bIsTranslating
    static readonly int bIsTranslating_Offset;
    public bool IsTranslating;
    
    // BoolProperty /Script/ControlRig.RigUnit_IsInteracting:bIsRotating
    static readonly int bIsRotating_Offset;
    public bool IsRotating;
    
    // BoolProperty /Script/ControlRig.RigUnit_IsInteracting:bIsScaling
    static readonly int bIsScaling_Offset;
    public bool IsScaling;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_IsInteracting()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_IsInteracting");
        
        bIsInteracting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsInteracting");
        bIsTranslating_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsTranslating");
        bIsRotating_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsRotating");
        bIsScaling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsScaling");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_IsInteracting(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsInteracting = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsInteracting_Offset), 0, null);
            IsTranslating = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsTranslating_Offset), 0, null);
            IsRotating = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsRotating_Offset), 0, null);
            IsScaling = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsScaling_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsInteracting_Offset), 0, null, IsInteracting);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsTranslating_Offset), 0, null, IsTranslating);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsRotating_Offset), 0, null, IsRotating);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsScaling_Offset), 0, null, IsScaling);
        }
    }
}

public static class RigUnit_IsInteractingMarshaler
{
    public static RigUnit_IsInteracting FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_IsInteracting(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_IsInteracting obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_IsInteracting.NativeDataSize;
    }
}