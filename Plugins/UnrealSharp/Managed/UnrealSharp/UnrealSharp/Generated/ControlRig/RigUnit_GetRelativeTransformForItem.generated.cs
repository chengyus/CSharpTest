using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetRelativeTransformForItem
{
    // StructProperty /Script/ControlRig.RigUnit_GetRelativeTransformForItem:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // BoolProperty /Script/ControlRig.RigUnit_GetRelativeTransformForItem:bChildInitial
    static readonly int bChildInitial_Offset;
    public bool ChildInitial;
    
    // StructProperty /Script/ControlRig.RigUnit_GetRelativeTransformForItem:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.ControlRig.RigElementKey Parent;
    
    // BoolProperty /Script/ControlRig.RigUnit_GetRelativeTransformForItem:bParentInitial
    static readonly int bParentInitial_Offset;
    public bool ParentInitial;
    
    // StructProperty /Script/ControlRig.RigUnit_GetRelativeTransformForItem:RelativeTransform
    static readonly int RelativeTransform_Offset;
    public UnrealSharp.Transform RelativeTransform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetRelativeTransformForItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetRelativeTransformForItem");
        
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        bChildInitial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChildInitial");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        bParentInitial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bParentInitial");
        RelativeTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelativeTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetRelativeTransformForItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            ChildInitial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bChildInitial_Offset), 0, null);
            Parent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            ParentInitial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bParentInitial_Offset), 0, null);
            RelativeTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, RelativeTransform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Child_Offset), 0, null, Child);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bChildInitial_Offset), 0, null, ChildInitial);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bParentInitial_Offset), 0, null, ParentInitial);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, RelativeTransform_Offset), 0, null, RelativeTransform);
        }
    }
}

public static class RigUnit_GetRelativeTransformForItemMarshaler
{
    public static RigUnit_GetRelativeTransformForItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetRelativeTransformForItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetRelativeTransformForItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetRelativeTransformForItem.NativeDataSize;
    }
}