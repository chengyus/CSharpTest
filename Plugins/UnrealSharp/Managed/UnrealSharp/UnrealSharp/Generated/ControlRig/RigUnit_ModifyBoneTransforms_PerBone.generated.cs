using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ModifyBoneTransforms_PerBone
{
    // NameProperty /Script/ControlRig.RigUnit_ModifyBoneTransforms_PerBone:Bone
    static readonly int Bone_Offset;
    public Name Bone;
    
    // StructProperty /Script/ControlRig.RigUnit_ModifyBoneTransforms_PerBone:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ModifyBoneTransforms_PerBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ModifyBoneTransforms_PerBone");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ModifyBoneTransforms_PerBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Bone_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Bone_Offset), 0, null, Bone);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class RigUnit_ModifyBoneTransforms_PerBoneMarshaler
{
    public static RigUnit_ModifyBoneTransforms_PerBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ModifyBoneTransforms_PerBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ModifyBoneTransforms_PerBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ModifyBoneTransforms_PerBone.NativeDataSize;
    }
}