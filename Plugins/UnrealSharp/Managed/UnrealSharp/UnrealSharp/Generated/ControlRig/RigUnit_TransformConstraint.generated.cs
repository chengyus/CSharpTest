using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TransformConstraint
{
    // NameProperty /Script/ControlRig.RigUnit_TransformConstraint:Bone
    static readonly int Bone_Offset;
    public Name Bone;
    
    // EnumProperty /Script/ControlRig.RigUnit_TransformConstraint:BaseTransformSpace
    static readonly int BaseTransformSpace_Offset;
    public UnrealSharp.ControlRig.ETransformSpaceMode BaseTransformSpace;
    
    // StructProperty /Script/ControlRig.RigUnit_TransformConstraint:BaseTransform
    static readonly int BaseTransform_Offset;
    public UnrealSharp.Transform BaseTransform;
    
    // NameProperty /Script/ControlRig.RigUnit_TransformConstraint:BaseBone
    static readonly int BaseBone_Offset;
    public Name BaseBone;
    
    // BoolProperty /Script/ControlRig.RigUnit_TransformConstraint:bUseInitialTransforms
    static readonly int bUseInitialTransforms_Offset;
    public bool UseInitialTransforms;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TransformConstraint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TransformConstraint");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        BaseTransformSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseTransformSpace");
        BaseTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseTransform");
        BaseBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseBone");
        bUseInitialTransforms_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseInitialTransforms");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TransformConstraint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Bone_Offset), 0, null);
            BaseTransformSpace = BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.FromNative(IntPtr.Add(InNativeStruct, BaseTransformSpace_Offset), 0, null);
            BaseTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, BaseTransform_Offset), 0, null);
            BaseBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BaseBone_Offset), 0, null);
            UseInitialTransforms = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseInitialTransforms_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Bone_Offset), 0, null, Bone);
            BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.ToNative(IntPtr.Add(Buffer, BaseTransformSpace_Offset), 0, null, BaseTransformSpace);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, BaseTransform_Offset), 0, null, BaseTransform);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BaseBone_Offset), 0, null, BaseBone);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseInitialTransforms_Offset), 0, null, UseInitialTransforms);
        }
    }
}

public static class RigUnit_TransformConstraintMarshaler
{
    public static RigUnit_TransformConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TransformConstraint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TransformConstraint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TransformConstraint.NativeDataSize;
    }
}