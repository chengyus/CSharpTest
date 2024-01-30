using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_TransformFromControlRigSpline
{
    // StructProperty /Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline:UpVector
    static readonly int UpVector_Offset;
    public System.DoubleNumerics.Vector3 UpVector;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline:Roll
    static readonly int Roll_Offset;
    public float Roll;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline:U
    static readonly int U_Offset;
    public float U;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TransformFromControlRigSpline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TransformFromControlRigSpline");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        UpVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpVector");
        Roll_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Roll");
        U_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "U");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TransformFromControlRigSpline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            UpVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, UpVector_Offset), 0, null);
            Roll = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Roll_Offset), 0, null);
            U = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, U_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, UpVector_Offset), 0, null, UpVector);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Roll_Offset), 0, null, Roll);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, U_Offset), 0, null, U);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class RigUnit_TransformFromControlRigSplineMarshaler
{
    public static RigUnit_TransformFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TransformFromControlRigSpline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TransformFromControlRigSpline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TransformFromControlRigSpline.NativeDataSize;
    }
}