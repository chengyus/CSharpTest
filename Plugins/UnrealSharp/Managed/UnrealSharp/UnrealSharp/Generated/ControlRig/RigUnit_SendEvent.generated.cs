using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SendEvent
{
    // EnumProperty /Script/ControlRig.RigUnit_SendEvent:Event
    static readonly int Event_Offset;
    public UnrealSharp.ControlRig.ERigEvent Event;
    
    // StructProperty /Script/ControlRig.RigUnit_SendEvent:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // FloatProperty /Script/ControlRig.RigUnit_SendEvent:OffsetInSeconds
    static readonly int OffsetInSeconds_Offset;
    public float OffsetInSeconds;
    
    // BoolProperty /Script/ControlRig.RigUnit_SendEvent:bEnable
    static readonly int bEnable_Offset;
    public bool Enable;
    
    // BoolProperty /Script/ControlRig.RigUnit_SendEvent:bOnlyDuringInteraction
    static readonly int bOnlyDuringInteraction_Offset;
    public bool OnlyDuringInteraction;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SendEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SendEvent");
        
        Event_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Event");
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        OffsetInSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffsetInSeconds");
        bEnable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnable");
        bOnlyDuringInteraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOnlyDuringInteraction");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SendEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Event = BlittableMarshaller<UnrealSharp.ControlRig.ERigEvent>.FromNative(IntPtr.Add(InNativeStruct, Event_Offset), 0, null);
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            OffsetInSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OffsetInSeconds_Offset), 0, null);
            Enable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnable_Offset), 0, null);
            OnlyDuringInteraction = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOnlyDuringInteraction_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigEvent>.ToNative(IntPtr.Add(Buffer, Event_Offset), 0, null, Event);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OffsetInSeconds_Offset), 0, null, OffsetInSeconds);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnable_Offset), 0, null, Enable);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOnlyDuringInteraction_Offset), 0, null, OnlyDuringInteraction);
        }
    }
}

public static class RigUnit_SendEventMarshaler
{
    public static RigUnit_SendEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SendEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SendEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SendEvent.NativeDataSize;
    }
}