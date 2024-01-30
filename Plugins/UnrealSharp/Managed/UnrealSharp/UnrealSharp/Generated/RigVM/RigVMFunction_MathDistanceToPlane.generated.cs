using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDistanceToPlane
{
    // StructProperty /Script/RigVM.RigVMFunction_MathDistanceToPlane:Point
    static readonly int Point_Offset;
    public System.DoubleNumerics.Vector3 Point;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathDistanceToPlane:PlanePoint
    static readonly int PlanePoint_Offset;
    public System.DoubleNumerics.Vector3 PlanePoint;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathDistanceToPlane:PlaneNormal
    static readonly int PlaneNormal_Offset;
    public System.DoubleNumerics.Vector3 PlaneNormal;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathDistanceToPlane:ClosestPointOnPlane
    static readonly int ClosestPointOnPlane_Offset;
    public System.DoubleNumerics.Vector3 ClosestPointOnPlane;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathDistanceToPlane:SignedDistance
    static readonly int SignedDistance_Offset;
    public float SignedDistance;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDistanceToPlane()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDistanceToPlane");
        
        Point_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Point");
        PlanePoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlanePoint");
        PlaneNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaneNormal");
        ClosestPointOnPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ClosestPointOnPlane");
        SignedDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SignedDistance");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDistanceToPlane(IntPtr InNativeStruct)
    {
        unsafe
        {
            Point = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Point_Offset), 0, null);
            PlanePoint = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PlanePoint_Offset), 0, null);
            PlaneNormal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PlaneNormal_Offset), 0, null);
            ClosestPointOnPlane = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ClosestPointOnPlane_Offset), 0, null);
            SignedDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SignedDistance_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Point_Offset), 0, null, Point);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PlanePoint_Offset), 0, null, PlanePoint);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PlaneNormal_Offset), 0, null, PlaneNormal);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ClosestPointOnPlane_Offset), 0, null, ClosestPointOnPlane);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SignedDistance_Offset), 0, null, SignedDistance);
        }
    }
}

public static class RigVMFunction_MathDistanceToPlaneMarshaler
{
    public static RigVMFunction_MathDistanceToPlane FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDistanceToPlane(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDistanceToPlane obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDistanceToPlane.NativeDataSize;
    }
}