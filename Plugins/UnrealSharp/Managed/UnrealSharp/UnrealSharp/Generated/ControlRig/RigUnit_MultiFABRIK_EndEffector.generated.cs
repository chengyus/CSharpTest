using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_MultiFABRIK_EndEffector
{
    // NameProperty /Script/ControlRig.RigUnit_MultiFABRIK_EndEffector:Bone
    static readonly int Bone_Offset;
    public Name Bone;
    
    // StructProperty /Script/ControlRig.RigUnit_MultiFABRIK_EndEffector:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_MultiFABRIK_EndEffector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_MultiFABRIK_EndEffector");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_MultiFABRIK_EndEffector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Bone_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Bone_Offset), 0, null, Bone);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
        }
    }
}

public static class RigUnit_MultiFABRIK_EndEffectorMarshaler
{
    public static RigUnit_MultiFABRIK_EndEffector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_MultiFABRIK_EndEffector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_MultiFABRIK_EndEffector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_MultiFABRIK_EndEffector.NativeDataSize;
    }
}