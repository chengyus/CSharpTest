using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformSelectBool
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathTransformSelectBool:Condition
    static readonly int Condition_Offset;
    public bool Condition;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformSelectBool:IfTrue
    static readonly int IfTrue_Offset;
    public UnrealSharp.Transform IfTrue;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformSelectBool:IfFalse
    static readonly int IfFalse_Offset;
    public UnrealSharp.Transform IfFalse;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformSelectBool:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformSelectBool()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformSelectBool");
        
        Condition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Condition");
        IfTrue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfTrue");
        IfFalse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IfFalse");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformSelectBool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Condition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Condition_Offset), 0, null);
            IfTrue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, IfTrue_Offset), 0, null);
            IfFalse = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, IfFalse_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Condition_Offset), 0, null, Condition);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, IfTrue_Offset), 0, null, IfTrue);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, IfFalse_Offset), 0, null, IfFalse);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathTransformSelectBoolMarshaler
{
    public static RigVMFunction_MathTransformSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformSelectBool(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformSelectBool obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformSelectBool.NativeDataSize;
    }
}