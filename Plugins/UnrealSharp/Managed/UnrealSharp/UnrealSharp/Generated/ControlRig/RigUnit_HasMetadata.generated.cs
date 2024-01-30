using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HasMetadata
{
    // StructProperty /Script/ControlRig.RigUnit_HasMetadata:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // NameProperty /Script/ControlRig.RigUnit_HasMetadata:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // EnumProperty /Script/ControlRig.RigUnit_HasMetadata:Type
    static readonly int Type_Offset;
    public UnrealSharp.ControlRig.ERigMetadataType Type;
    
    // BoolProperty /Script/ControlRig.RigUnit_HasMetadata:Found
    static readonly int Found_Offset;
    public bool Found;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HasMetadata()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HasMetadata");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        Found_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Found");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HasMetadata(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.ControlRig.ERigMetadataType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            Found = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Found_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigMetadataType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Found_Offset), 0, null, Found);
        }
    }
}

public static class RigUnit_HasMetadataMarshaler
{
    public static RigUnit_HasMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HasMetadata(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HasMetadata obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HasMetadata.NativeDataSize;
    }
}