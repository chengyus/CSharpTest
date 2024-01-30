using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleFloor
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleFloor:Value
    static readonly int Value_Offset;
    public double Value;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleFloor:Result
    static readonly int Result_Offset;
    public double Result;
    
    // IntProperty /Script/RigVM.RigVMFunction_MathDoubleFloor:Int
    static readonly int Int_Offset;
    public int Int;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleFloor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleFloor");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        Int_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Int");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleFloor(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Result = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            Int = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Int_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Int_Offset), 0, null, Int);
        }
    }
}

public static class RigVMFunction_MathDoubleFloorMarshaler
{
    public static RigVMFunction_MathDoubleFloor FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleFloor(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleFloor obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleFloor.NativeDataSize;
    }
}