using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathIntersectPlane
{
    // StructProperty /Script/RigVM.RigVMFunction_MathIntersectPlane:Start
    static readonly int Start_Offset;
    public System.DoubleNumerics.Vector3 Start;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathIntersectPlane:Direction
    static readonly int Direction_Offset;
    public System.DoubleNumerics.Vector3 Direction;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathIntersectPlane:PlanePoint
    static readonly int PlanePoint_Offset;
    public System.DoubleNumerics.Vector3 PlanePoint;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathIntersectPlane:PlaneNormal
    static readonly int PlaneNormal_Offset;
    public System.DoubleNumerics.Vector3 PlaneNormal;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathIntersectPlane:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathIntersectPlane:Distance
    static readonly int Distance_Offset;
    public float Distance;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathIntersectPlane()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathIntersectPlane");
        
        Start_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Start");
        Direction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Direction");
        PlanePoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlanePoint");
        PlaneNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaneNormal");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        Distance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Distance");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathIntersectPlane(IntPtr InNativeStruct)
    {
        unsafe
        {
            Start = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Start_Offset), 0, null);
            Direction = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Direction_Offset), 0, null);
            PlanePoint = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PlanePoint_Offset), 0, null);
            PlaneNormal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PlaneNormal_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            Distance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Distance_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Start_Offset), 0, null, Start);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Direction_Offset), 0, null, Direction);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PlanePoint_Offset), 0, null, PlanePoint);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PlaneNormal_Offset), 0, null, PlaneNormal);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Distance_Offset), 0, null, Distance);
        }
    }
}

public static class RigVMFunction_MathIntersectPlaneMarshaler
{
    public static RigVMFunction_MathIntersectPlane FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathIntersectPlane(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathIntersectPlane obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathIntersectPlane.NativeDataSize;
    }
}