using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionSwingTwist
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSwingTwist:Input
    static readonly int Input_Offset;
    public System.DoubleNumerics.Quaternion Input;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSwingTwist:TwistAxis
    static readonly int TwistAxis_Offset;
    public System.DoubleNumerics.Vector3 TwistAxis;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSwingTwist:Swing
    static readonly int Swing_Offset;
    public System.DoubleNumerics.Quaternion Swing;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSwingTwist:Twist
    static readonly int Twist_Offset;
    public System.DoubleNumerics.Quaternion Twist;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionSwingTwist()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionSwingTwist");
        
        Input_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Input");
        TwistAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistAxis");
        Swing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Swing");
        Twist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Twist");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionSwingTwist(IntPtr InNativeStruct)
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

public static class RigVMFunction_MathQuaternionSwingTwistMarshaler
{
    public static RigVMFunction_MathQuaternionSwingTwist FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionSwingTwist(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionSwingTwist obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionSwingTwist.NativeDataSize;
    }
}