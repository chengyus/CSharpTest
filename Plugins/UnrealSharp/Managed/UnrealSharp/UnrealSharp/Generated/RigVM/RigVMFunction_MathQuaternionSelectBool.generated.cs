using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionSelectBool
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathQuaternionSelectBool:Condition
    static readonly int Condition_Offset;
    public bool Condition;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSelectBool:IfTrue
    static readonly int IfTrue_Offset;
    public System.DoubleNumerics.Quaternion IfTrue;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSelectBool:IfFalse
    static readonly int IfFalse_Offset;
    public System.DoubleNumerics.Quaternion IfFalse;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionSelectBool:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionSelectBool()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionSelectBool");
        
        Condition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Condition");
        IfTrue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfTrue");
        IfFalse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfFalse");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionSelectBool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Condition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Condition_Offset), 0, null);
            IfTrue = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, IfTrue_Offset), 0, null);
            IfFalse = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, IfFalse_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Condition_Offset), 0, null, Condition);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, IfTrue_Offset), 0, null, IfTrue);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, IfFalse_Offset), 0, null, IfFalse);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionSelectBoolMarshaler
{
    public static RigVMFunction_MathQuaternionSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionSelectBool(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionSelectBool obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionSelectBool.NativeDataSize;
    }
}