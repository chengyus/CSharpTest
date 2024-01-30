using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathBoolNotEquals
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolNotEquals:A
    static readonly int A_Offset;
    public bool A;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolNotEquals:B
    static readonly int B_Offset;
    public bool B;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolNotEquals:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathBoolNotEquals()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathBoolNotEquals");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathBoolNotEquals(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathBoolNotEqualsMarshaler
{
    public static RigVMFunction_MathBoolNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathBoolNotEquals(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathBoolNotEquals obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathBoolNotEquals.NativeDataSize;
    }
}