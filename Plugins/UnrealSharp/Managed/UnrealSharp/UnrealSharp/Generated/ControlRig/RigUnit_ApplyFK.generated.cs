using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ApplyFK
{
    // NameProperty /Script/ControlRig.RigUnit_ApplyFK:Joint
    static readonly int Joint_Offset;
    public Name Joint;
    
    // StructProperty /Script/ControlRig.RigUnit_ApplyFK:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/ControlRig.RigUnit_ApplyFK:Filter
    static readonly int Filter_Offset;
    public UnrealSharp.AnimationCore.TransformFilter Filter;
    
    // EnumProperty /Script/ControlRig.RigUnit_ApplyFK:ApplyTransformMode
    static readonly int ApplyTransformMode_Offset;
    public UnrealSharp.ControlRig.EApplyTransformMode ApplyTransformMode;
    
    // EnumProperty /Script/ControlRig.RigUnit_ApplyFK:ApplyTransformSpace
    static readonly int ApplyTransformSpace_Offset;
    public UnrealSharp.ControlRig.ETransformSpaceMode ApplyTransformSpace;
    
    // StructProperty /Script/ControlRig.RigUnit_ApplyFK:BaseTransform
    static readonly int BaseTransform_Offset;
    public UnrealSharp.Transform BaseTransform;
    
    // NameProperty /Script/ControlRig.RigUnit_ApplyFK:BaseJoint
    static readonly int BaseJoint_Offset;
    public Name BaseJoint;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ApplyFK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ApplyFK");
        
        Joint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Joint");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Filter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Filter");
        ApplyTransformMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApplyTransformMode");
        ApplyTransformSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApplyTransformSpace");
        BaseTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseTransform");
        BaseJoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseJoint");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ApplyFK(IntPtr InNativeStruct)
    {
        unsafe
        {
            Joint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Joint_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Filter = UnrealSharp.AnimationCore.TransformFilterMarshaler.FromNative(IntPtr.Add(InNativeStruct, Filter_Offset), 0, null);
            ApplyTransformMode = BlittableMarshaller<UnrealSharp.ControlRig.EApplyTransformMode>.FromNative(IntPtr.Add(InNativeStruct, ApplyTransformMode_Offset), 0, null);
            ApplyTransformSpace = BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.FromNative(IntPtr.Add(InNativeStruct, ApplyTransformSpace_Offset), 0, null);
            BaseTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, BaseTransform_Offset), 0, null);
            BaseJoint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BaseJoint_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Joint_Offset), 0, null, Joint);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            UnrealSharp.AnimationCore.TransformFilterMarshaler.ToNative(IntPtr.Add(Buffer, Filter_Offset), 0, null, Filter);
            BlittableMarshaller<UnrealSharp.ControlRig.EApplyTransformMode>.ToNative(IntPtr.Add(Buffer, ApplyTransformMode_Offset), 0, null, ApplyTransformMode);
            BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.ToNative(IntPtr.Add(Buffer, ApplyTransformSpace_Offset), 0, null, ApplyTransformSpace);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, BaseTransform_Offset), 0, null, BaseTransform);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BaseJoint_Offset), 0, null, BaseJoint);
        }
    }
}

public static class RigUnit_ApplyFKMarshaler
{
    public static RigUnit_ApplyFK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ApplyFK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ApplyFK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ApplyFK.NativeDataSize;
    }
}