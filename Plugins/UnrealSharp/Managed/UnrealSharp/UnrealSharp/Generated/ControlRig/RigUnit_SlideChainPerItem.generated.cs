using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SlideChainPerItem
{
    // StructProperty /Script/ControlRig.RigUnit_SlideChainPerItem:Items
    static readonly int Items_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Items;
    
    // FloatProperty /Script/ControlRig.RigUnit_SlideChainPerItem:SlideAmount
    static readonly int SlideAmount_Offset;
    public float SlideAmount;
    
    // BoolProperty /Script/ControlRig.RigUnit_SlideChainPerItem:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SlideChainPerItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SlideChainPerItem");
        
        Items_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Items");
        SlideAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SlideAmount");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SlideChainPerItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Items = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Items_Offset), 0, null);
            SlideAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SlideAmount_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Items_Offset), 0, null, Items);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SlideAmount_Offset), 0, null, SlideAmount);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_SlideChainPerItemMarshaler
{
    public static RigUnit_SlideChainPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SlideChainPerItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SlideChainPerItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SlideChainPerItem.NativeDataSize;
    }
}