using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ToSwingAndTwist
{
    // StructProperty /Script/ControlRig.RigUnit_ToSwingAndTwist:Input
    static readonly int Input_Offset;
    public System.DoubleNumerics.Quaternion Input;
    
    // StructProperty /Script/ControlRig.RigUnit_ToSwingAndTwist:TwistAxis
    static readonly int TwistAxis_Offset;
    public System.DoubleNumerics.Vector3 TwistAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_ToSwingAndTwist:Swing
    static readonly int Swing_Offset;
    public System.DoubleNumerics.Quaternion Swing;
    
    // StructProperty /Script/ControlRig.RigUnit_ToSwingAndTwist:Twist
    static readonly int Twist_Offset;
    public System.DoubleNumerics.Quaternion Twist;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ToSwingAndTwist()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ToSwingAndTwist");
        
        Input_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Input");
        TwistAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistAxis");
        Swing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Swing");
        Twist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Twist");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ToSwingAndTwist(IntPtr InNativeStruct)
    {
        unsafe
        {
            Input = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Input_Offset), 0, null);
            TwistAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TwistAxis_Offset), 0, null);
            Swing = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Swing_Offset), 0, null);
            Twist = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Twist_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Input_Offset), 0, null, Input);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TwistAxis_Offset), 0, null, TwistAxis);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Swing_Offset), 0, null, Swing);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Twist_Offset), 0, null, Twist);
        }
    }
}

public static class RigUnit_ToSwingAndTwistMarshaler
{
    public static RigUnit_ToSwingAndTwist FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ToSwingAndTwist(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ToSwingAndTwist obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ToSwingAndTwist.NativeDataSize;
    }
}