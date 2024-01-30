using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ToRigSpace_Rotation
{
    // StructProperty /Script/ControlRig.RigUnit_ToRigSpace_Rotation:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Quaternion Value;
    
    // StructProperty /Script/ControlRig.RigUnit_ToRigSpace_Rotation:Global
    static readonly int Global_Offset;
    public System.DoubleNumerics.Quaternion Global;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ToRigSpace_Rotation()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ToRigSpace_Rotation");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ToRigSpace_Rotation(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Global = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
        }
    }
}

public static class RigUnit_ToRigSpace_RotationMarshaler
{
    public static RigUnit_ToRigSpace_Rotation FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ToRigSpace_Rotation(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ToRigSpace_Rotation obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ToRigSpace_Rotation.NativeDataSize;
    }
}