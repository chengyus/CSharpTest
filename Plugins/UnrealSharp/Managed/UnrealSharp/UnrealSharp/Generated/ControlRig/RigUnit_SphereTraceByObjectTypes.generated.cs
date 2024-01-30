using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SphereTraceByObjectTypes
{
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByObjectTypes:Start
    static readonly int Start_Offset;
    public System.DoubleNumerics.Vector3 Start;
    
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByObjectTypes:End
    static readonly int End_Offset;
    public System.DoubleNumerics.Vector3 End;
    
    // FloatProperty /Script/ControlRig.RigUnit_SphereTraceByObjectTypes:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    // BoolProperty /Script/ControlRig.RigUnit_SphereTraceByObjectTypes:bHit
    static readonly int bHit_Offset;
    public bool Hit;
    
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByObjectTypes:HitLocation
    static readonly int HitLocation_Offset;
    public System.DoubleNumerics.Vector3 HitLocation;
    
    // StructProperty /Script/ControlRig.RigUnit_SphereTraceByObjectTypes:HitNormal
    static readonly int HitNormal_Offset;
    public System.DoubleNumerics.Vector3 HitNormal;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SphereTraceByObjectTypes()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SphereTraceByObjectTypes");
        
        Start_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Start");
        End_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "End");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        bHit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHit");
        HitLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitLocation");
        HitNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitNormal");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SphereTraceByObjectTypes(IntPtr InNativeStruct)
    {
        unsafe
        {
            Start = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Start_Offset), 0, null);
            End = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, End_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
            Hit = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHit_Offset), 0, null);
            HitLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, HitLocation_Offset), 0, null);
            HitNormal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, HitNormal_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Start_Offset), 0, null, Start);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, End_Offset), 0, null, End);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHit_Offset), 0, null, Hit);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, HitLocation_Offset), 0, null, HitLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, HitNormal_Offset), 0, null, HitNormal);
        }
    }
}

public static class RigUnit_SphereTraceByObjectTypesMarshaler
{
    public static RigUnit_SphereTraceByObjectTypes FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SphereTraceByObjectTypes(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SphereTraceByObjectTypes obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SphereTraceByObjectTypes.NativeDataSize;
    }
}