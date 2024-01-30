using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetJointTransform
{
    // NameProperty /Script/ControlRig.RigUnit_GetJointTransform:Joint
    static readonly int Joint_Offset;
    public Name Joint;
    
    // EnumProperty /Script/ControlRig.RigUnit_GetJointTransform:Type
    static readonly int Type_Offset;
    public UnrealSharp.ControlRig.ETransformGetterType Type;
    
    // EnumProperty /Script/ControlRig.RigUnit_GetJointTransform:TransformSpace
    static readonly int TransformSpace_Offset;
    public UnrealSharp.ControlRig.ETransformSpaceMode TransformSpace;
    
    // StructProperty /Script/ControlRig.RigUnit_GetJointTransform:BaseTransform
    static readonly int BaseTransform_Offset;
    public UnrealSharp.Transform BaseTransform;
    
    // NameProperty /Script/ControlRig.RigUnit_GetJointTransform:BaseJoint
    static readonly int BaseJoint_Offset;
    public Name BaseJoint;
    
    // StructProperty /Script/ControlRig.RigUnit_GetJointTransform:Output
    static readonly int Output_Offset;
    public UnrealSharp.Transform Output;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetJointTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetJointTransform");
        
        Joint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Joint");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        TransformSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TransformSpace");
        BaseTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseTransform");
        BaseJoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseJoint");
        Output_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Output");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetJointTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Joint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Joint_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.ControlRig.ETransformGetterType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            TransformSpace = BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.FromNative(IntPtr.Add(InNativeStruct, TransformSpace_Offset), 0, null);
            BaseTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, BaseTransform_Offset), 0, null);
            BaseJoint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BaseJoint_Offset), 0, null);
            Output = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Output_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Joint_Offset), 0, null, Joint);
            BlittableMarshaller<UnrealSharp.ControlRig.ETransformGetterType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.ToNative(IntPtr.Add(Buffer, TransformSpace_Offset), 0, null, TransformSpace);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, BaseTransform_Offset), 0, null, BaseTransform);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BaseJoint_Offset), 0, null, BaseJoint);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Output_Offset), 0, null, Output);
        }
    }
}

public static class RigUnit_GetJointTransformMarshaler
{
    public static RigUnit_GetJointTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetJointTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetJointTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetJointTransform.NativeDataSize;
    }
}