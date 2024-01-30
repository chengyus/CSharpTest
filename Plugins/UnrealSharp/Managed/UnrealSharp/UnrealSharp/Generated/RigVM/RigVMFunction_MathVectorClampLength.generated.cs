using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorClampLength
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorClampLength:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorClampLength:MinimumLength
    static readonly int MinimumLength_Offset;
    public float MinimumLength;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorClampLength:MaximumLength
    static readonly int MaximumLength_Offset;
    public float MaximumLength;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorClampLength:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorClampLength()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorClampLength");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        MinimumLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumLength");
        MaximumLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumLength");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorClampLength(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            MinimumLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinimumLength_Offset), 0, null);
            MaximumLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumLength_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinimumLength_Offset), 0, null, MinimumLength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumLength_Offset), 0, null, MaximumLength);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorClampLengthMarshaler
{
    public static RigVMFunction_MathVectorClampLength FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorClampLength(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorClampLength obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorClampLength.NativeDataSize;
    }
}