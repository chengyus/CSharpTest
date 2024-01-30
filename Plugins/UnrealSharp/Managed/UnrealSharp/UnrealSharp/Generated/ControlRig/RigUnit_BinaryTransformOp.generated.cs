using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_BinaryTransformOp
{
    // StructProperty /Script/ControlRig.RigUnit_BinaryTransformOp:Argument0
    static readonly int Argument0_Offset;
    public UnrealSharp.Transform Argument0;
    
    // StructProperty /Script/ControlRig.RigUnit_BinaryTransformOp:Argument1
    static readonly int Argument1_Offset;
    public UnrealSharp.Transform Argument1;
    
    // StructProperty /Script/ControlRig.RigUnit_BinaryTransformOp:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_BinaryTransformOp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_BinaryTransformOp");
        
        Argument0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument0");
        Argument1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument1");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_BinaryTransformOp(IntPtr InNativeStruct)
    {
        unsafe
        {
            Argument0 = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Argument0_Offset), 0, null);
            Argument1 = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Argument1_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Argument0_Offset), 0, null, Argument0);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Argument1_Offset), 0, null, Argument1);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_BinaryTransformOpMarshaler
{
    public static RigUnit_BinaryTransformOp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_BinaryTransformOp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_BinaryTransformOp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_BinaryTransformOp.NativeDataSize;
    }
}