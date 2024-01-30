using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorSelectBool
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathVectorSelectBool:Condition
    static readonly int Condition_Offset;
    public bool Condition;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorSelectBool:IfTrue
    static readonly int IfTrue_Offset;
    public System.DoubleNumerics.Vector3 IfTrue;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorSelectBool:IfFalse
    static readonly int IfFalse_Offset;
    public System.DoubleNumerics.Vector3 IfFalse;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorSelectBool:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorSelectBool()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorSelectBool");
        
        Condition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Condition");
        IfTrue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfTrue");
        IfFalse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfFalse");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorSelectBool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Condition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Condition_Offset), 0, null);
            IfTrue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, IfTrue_Offset), 0, null);
            IfFalse = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, IfFalse_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Condition_Offset), 0, null, Condition);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, IfTrue_Offset), 0, null, IfTrue);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, IfFalse_Offset), 0, null, IfFalse);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorSelectBoolMarshaler
{
    public static RigVMFunction_MathVectorSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorSelectBool(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorSelectBool obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorSelectBool.NativeDataSize;
    }
}