using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_RemoveMetadataTag
{
    // StructProperty /Script/ControlRig.RigUnit_RemoveMetadataTag:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // NameProperty /Script/ControlRig.RigUnit_RemoveMetadataTag:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    // BoolProperty /Script/ControlRig.RigUnit_RemoveMetadataTag:Removed
    static readonly int Removed_Offset;
    public bool Removed;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_RemoveMetadataTag()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_RemoveMetadataTag");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        Removed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Removed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_RemoveMetadataTag(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
            Removed = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Removed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Removed_Offset), 0, null, Removed);
        }
    }
}

public static class RigUnit_RemoveMetadataTagMarshaler
{
    public static RigUnit_RemoveMetadataTag FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_RemoveMetadataTag(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_RemoveMetadataTag obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_RemoveMetadataTag.NativeDataSize;
    }
}