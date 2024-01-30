using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ConvertTransform
{
    // StructProperty /Script/ControlRig.RigUnit_ConvertTransform:Input
    static readonly int Input_Offset;
    public UnrealSharp.Transform Input;
    
    // StructProperty /Script/ControlRig.RigUnit_ConvertTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.AnimationCore.EulerTransform Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ConvertTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ConvertTransform");
        
        Input_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Input");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ConvertTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Input = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Input_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Input_Offset), 0, null, Input);
            BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_ConvertTransformMarshaler
{
    public static RigUnit_ConvertTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ConvertTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ConvertTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ConvertTransform.NativeDataSize;
    }
}