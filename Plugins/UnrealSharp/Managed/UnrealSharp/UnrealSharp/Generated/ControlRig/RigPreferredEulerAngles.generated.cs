using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigPreferredEulerAngles
{
    // EnumProperty /Script/ControlRig.RigPreferredEulerAngles:RotationOrder
    static readonly int RotationOrder_Offset;
    public UnrealSharp.AnimationCore.EEulerRotationOrder RotationOrder;
    
    // StructProperty /Script/ControlRig.RigPreferredEulerAngles:Current
    static readonly int Current_Offset;
    public System.DoubleNumerics.Vector3 Current;
    
    // StructProperty /Script/ControlRig.RigPreferredEulerAngles:Initial
    static readonly int Initial_Offset;
    public System.DoubleNumerics.Vector3 Initial;
    
    
    public static readonly int NativeDataSize;
    static RigPreferredEulerAngles()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigPreferredEulerAngles");
        
        RotationOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOrder");
        Current_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Current");
        Initial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Initial");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigPreferredEulerAngles(IntPtr InNativeStruct)
    {
        unsafe
        {
            RotationOrder = BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.FromNative(IntPtr.Add(InNativeStruct, RotationOrder_Offset), 0, null);
            Current = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Current_Offset), 0, null);
            Initial = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Initial_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.ToNative(IntPtr.Add(Buffer, RotationOrder_Offset), 0, null, RotationOrder);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Current_Offset), 0, null, Current);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Initial_Offset), 0, null, Initial);
        }
    }
}

public static class RigPreferredEulerAnglesMarshaler
{
    public static RigPreferredEulerAngles FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigPreferredEulerAngles(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigPreferredEulerAngles obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigPreferredEulerAngles.NativeDataSize;
    }
}