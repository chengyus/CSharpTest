using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_FindItemsWithMetadata
{
    // NameProperty /Script/ControlRig.RigUnit_FindItemsWithMetadata:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // EnumProperty /Script/ControlRig.RigUnit_FindItemsWithMetadata:Type
    static readonly int Type_Offset;
    public UnrealSharp.ControlRig.ERigMetadataType Type;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FindItemsWithMetadata()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FindItemsWithMetadata");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FindItemsWithMetadata(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.ControlRig.ERigMetadataType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigMetadataType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class RigUnit_FindItemsWithMetadataMarshaler
{
    public static RigUnit_FindItemsWithMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FindItemsWithMetadata(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FindItemsWithMetadata obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FindItemsWithMetadata.NativeDataSize;
    }
}