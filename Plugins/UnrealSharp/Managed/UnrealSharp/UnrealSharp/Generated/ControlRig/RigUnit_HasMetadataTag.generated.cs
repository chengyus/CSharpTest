using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HasMetadataTag
{
    // StructProperty /Script/ControlRig.RigUnit_HasMetadataTag:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // NameProperty /Script/ControlRig.RigUnit_HasMetadataTag:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    // BoolProperty /Script/ControlRig.RigUnit_HasMetadataTag:Found
    static readonly int Found_Offset;
    public bool Found;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HasMetadataTag()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HasMetadataTag");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        Found_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Found");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HasMetadataTag(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
            Found = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Found_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Found_Offset), 0, null, Found);
        }
    }
}

public static class RigUnit_HasMetadataTagMarshaler
{
    public static RigUnit_HasMetadataTag FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HasMetadataTag(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HasMetadataTag obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HasMetadataTag.NativeDataSize;
    }
}