using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformAccumulateArray
{
    // EnumProperty /Script/RigVM.RigVMFunction_MathTransformAccumulateArray:TargetSpace
    static readonly int TargetSpace_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace TargetSpace;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformAccumulateArray:Root
    static readonly int Root_Offset;
    public UnrealSharp.Transform Root;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformAccumulateArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformAccumulateArray");
        
        TargetSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetSpace");
        Root_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Root");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformAccumulateArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetSpace = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, TargetSpace_Offset), 0, null);
            Root = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Root_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, TargetSpace_Offset), 0, null, TargetSpace);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Root_Offset), 0, null, Root);
        }
    }
}

public static class RigVMFunction_MathTransformAccumulateArrayMarshaler
{
    public static RigVMFunction_MathTransformAccumulateArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformAccumulateArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformAccumulateArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformAccumulateArray.NativeDataSize;
    }
}