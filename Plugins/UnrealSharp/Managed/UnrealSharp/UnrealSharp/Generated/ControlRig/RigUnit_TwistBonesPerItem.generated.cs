using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwistBonesPerItem
{
    // StructProperty /Script/ControlRig.RigUnit_TwistBonesPerItem:Items
    static readonly int Items_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Items;
    
    // StructProperty /Script/ControlRig.RigUnit_TwistBonesPerItem:TwistAxis
    static readonly int TwistAxis_Offset;
    public System.DoubleNumerics.Vector3 TwistAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_TwistBonesPerItem:PoleAxis
    static readonly int PoleAxis_Offset;
    public System.DoubleNumerics.Vector3 PoleAxis;
    
    // EnumProperty /Script/ControlRig.RigUnit_TwistBonesPerItem:TwistEaseType
    static readonly int TwistEaseType_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType TwistEaseType;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwistBonesPerItem:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwistBonesPerItem:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwistBonesPerItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwistBonesPerItem");
        
        Items_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Items");
        TwistAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistAxis");
        PoleAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleAxis");
        TwistEaseType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistEaseType");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwistBonesPerItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Items = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Items_Offset), 0, null);
            TwistAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TwistAxis_Offset), 0, null);
            PoleAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleAxis_Offset), 0, null);
            TwistEaseType = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, TwistEaseType_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Items_Offset), 0, null, Items);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TwistAxis_Offset), 0, null, TwistAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleAxis_Offset), 0, null, PoleAxis);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, TwistEaseType_Offset), 0, null, TwistEaseType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_TwistBonesPerItemMarshaler
{
    public static RigUnit_TwistBonesPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwistBonesPerItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwistBonesPerItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwistBonesPerItem.NativeDataSize;
    }
}