using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ConvertEulerTransform
{
    // StructProperty /Script/ControlRig.RigUnit_ConvertEulerTransform:Input
    static readonly int Input_Offset;
    public UnrealSharp.AnimationCore.EulerTransform Input;
    
    // StructProperty /Script/ControlRig.RigUnit_ConvertEulerTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ConvertEulerTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ConvertEulerTransform");
        
        Input_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Input");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ConvertEulerTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Input = BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.FromNative(IntPtr.Add(InNativeStruct, Input_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.ToNative(IntPtr.Add(Buffer, Input_Offset), 0, null, Input);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_ConvertEulerTransformMarshaler
{
    public static RigUnit_ConvertEulerTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ConvertEulerTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ConvertEulerTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ConvertEulerTransform.NativeDataSize;
    }
}