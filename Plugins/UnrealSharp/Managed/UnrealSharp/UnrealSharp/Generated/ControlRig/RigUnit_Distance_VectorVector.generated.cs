using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Distance_VectorVector
{
    // StructProperty /Script/ControlRig.RigUnit_Distance_VectorVector:Argument0
    static readonly int Argument0_Offset;
    public System.DoubleNumerics.Vector3 Argument0;
    
    // StructProperty /Script/ControlRig.RigUnit_Distance_VectorVector:Argument1
    static readonly int Argument1_Offset;
    public System.DoubleNumerics.Vector3 Argument1;
    
    // FloatProperty /Script/ControlRig.RigUnit_Distance_VectorVector:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_Distance_VectorVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Distance_VectorVector");
        
        Argument0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument0");
        Argument1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument1");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Distance_VectorVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Argument0 = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Argument0_Offset), 0, null);
            Argument1 = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Argument1_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Argument0_Offset), 0, null, Argument0);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Argument1_Offset), 0, null, Argument1);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_Distance_VectorVectorMarshaler
{
    public static RigUnit_Distance_VectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Distance_VectorVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Distance_VectorVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Distance_VectorVector.NativeDataSize;
    }
}