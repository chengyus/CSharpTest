using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathFloatSelectBool
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathFloatSelectBool:Condition
    static readonly int Condition_Offset;
    public bool Condition;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatSelectBool:IfTrue
    static readonly int IfTrue_Offset;
    public float IfTrue;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatSelectBool:IfFalse
    static readonly int IfFalse_Offset;
    public float IfFalse;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatSelectBool:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathFloatSelectBool()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathFloatSelectBool");
        
        Condition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Condition");
        IfTrue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfTrue");
        IfFalse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfFalse");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathFloatSelectBool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Condition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Condition_Offset), 0, null);
            IfTrue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IfTrue_Offset), 0, null);
            IfFalse = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IfFalse_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Condition_Offset), 0, null, Condition);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IfTrue_Offset), 0, null, IfTrue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IfFalse_Offset), 0, null, IfFalse);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathFloatSelectBoolMarshaler
{
    public static RigVMFunction_MathFloatSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathFloatSelectBool(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathFloatSelectBool obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathFloatSelectBool.NativeDataSize;
    }
}