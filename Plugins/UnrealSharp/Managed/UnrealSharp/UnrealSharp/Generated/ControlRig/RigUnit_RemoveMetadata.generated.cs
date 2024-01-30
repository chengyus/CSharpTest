using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_RemoveMetadata
{
    // StructProperty /Script/ControlRig.RigUnit_RemoveMetadata:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // NameProperty /Script/ControlRig.RigUnit_RemoveMetadata:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // BoolProperty /Script/ControlRig.RigUnit_RemoveMetadata:Removed
    static readonly int Removed_Offset;
    public bool Removed;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_RemoveMetadata()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_RemoveMetadata");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Removed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Removed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_RemoveMetadata(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Removed = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Removed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Removed_Offset), 0, null, Removed);
        }
    }
}

public static class RigUnit_RemoveMetadataMarshaler
{
    public static RigUnit_RemoveMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_RemoveMetadata(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_RemoveMetadata obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_RemoveMetadata.NativeDataSize;
    }
}