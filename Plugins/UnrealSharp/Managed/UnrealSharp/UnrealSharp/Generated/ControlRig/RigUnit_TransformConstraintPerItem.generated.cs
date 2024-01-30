using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TransformConstraintPerItem
{
    // StructProperty /Script/ControlRig.RigUnit_TransformConstraintPerItem:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // EnumProperty /Script/ControlRig.RigUnit_TransformConstraintPerItem:BaseTransformSpace
    static readonly int BaseTransformSpace_Offset;
    public UnrealSharp.ControlRig.ETransformSpaceMode BaseTransformSpace;
    
    // StructProperty /Script/ControlRig.RigUnit_TransformConstraintPerItem:BaseTransform
    static readonly int BaseTransform_Offset;
    public UnrealSharp.Transform BaseTransform;
    
    // StructProperty /Script/ControlRig.RigUnit_TransformConstraintPerItem:BaseItem
    static readonly int BaseItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey BaseItem;
    
    // BoolProperty /Script/ControlRig.RigUnit_TransformConstraintPerItem:bUseInitialTransforms
    static readonly int bUseInitialTransforms_Offset;
    public bool UseInitialTransforms;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TransformConstraintPerItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TransformConstraintPerItem");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        BaseTransformSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseTransformSpace");
        BaseTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseTransform");
        BaseItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseItem");
        bUseInitialTransforms_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseInitialTransforms");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TransformConstraintPerItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            BaseTransformSpace = BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.FromNative(IntPtr.Add(InNativeStruct, BaseTransformSpace_Offset), 0, null);
            BaseTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, BaseTransform_Offset), 0, null);
            BaseItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, BaseItem_Offset), 0, null);
            UseInitialTransforms = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseInitialTransforms_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<UnrealSharp.ControlRig.ETransformSpaceMode>.ToNative(IntPtr.Add(Buffer, BaseTransformSpace_Offset), 0, null, BaseTransformSpace);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, BaseTransform_Offset), 0, null, BaseTransform);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, BaseItem_Offset), 0, null, BaseItem);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseInitialTransforms_Offset), 0, null, UseInitialTransforms);
        }
    }
}

public static class RigUnit_TransformConstraintPerItemMarshaler
{
    public static RigUnit_TransformConstraintPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TransformConstraintPerItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TransformConstraintPerItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TransformConstraintPerItem.NativeDataSize;
    }
}