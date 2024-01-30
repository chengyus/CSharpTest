using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetBoneInitialTransform
{
    // NameProperty /Script/ControlRig.RigUnit_SetBoneInitialTransform:Bone
    static readonly int Bone_Offset;
    public Name Bone;
    
    // StructProperty /Script/ControlRig.RigUnit_SetBoneInitialTransform:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/ControlRig.RigUnit_SetBoneInitialTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    // EnumProperty /Script/ControlRig.RigUnit_SetBoneInitialTransform:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // BoolProperty /Script/ControlRig.RigUnit_SetBoneInitialTransform:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetBoneInitialTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetBoneInitialTransform");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetBoneInitialTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Bone_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Bone_Offset), 0, null, Bone);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_SetBoneInitialTransformMarshaler
{
    public static RigUnit_SetBoneInitialTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetBoneInitialTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetBoneInitialTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetBoneInitialTransform.NativeDataSize;
    }
}