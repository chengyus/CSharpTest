using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformTransformVector
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformTransformVector:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformTransformVector:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformTransformVector:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformTransformVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformTransformVector");
        
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformTransformVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathTransformTransformVectorMarshaler
{
    public static RigVMFunction_MathTransformTransformVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformTransformVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformTransformVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformTransformVector.NativeDataSize;
    }
}