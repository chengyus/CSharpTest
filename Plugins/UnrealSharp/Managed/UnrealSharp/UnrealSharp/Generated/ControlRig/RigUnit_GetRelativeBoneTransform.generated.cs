using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetRelativeBoneTransform
{
    // NameProperty /Script/ControlRig.RigUnit_GetRelativeBoneTransform:Bone
    static readonly int Bone_Offset;
    public Name Bone;
    
    // NameProperty /Script/ControlRig.RigUnit_GetRelativeBoneTransform:Space
    static readonly int Space_Offset;
    public Name Space;
    
    // StructProperty /Script/ControlRig.RigUnit_GetRelativeBoneTransform:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetRelativeBoneTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetRelativeBoneTransform");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetRelativeBoneTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Bone_Offset), 0, null);
            Space = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Bone_Offset), 0, null, Bone);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class RigUnit_GetRelativeBoneTransformMarshaler
{
    public static RigUnit_GetRelativeBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetRelativeBoneTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetRelativeBoneTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetRelativeBoneTransform.NativeDataSize;
    }
}