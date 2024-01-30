using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionNameSearchArray
{
    // NameProperty /Script/ControlRig.RigUnit_CollectionNameSearchArray:PartialName
    static readonly int PartialName_Offset;
    public Name PartialName;
    
    // EnumProperty /Script/ControlRig.RigUnit_CollectionNameSearchArray:TypeToSearch
    static readonly int TypeToSearch_Offset;
    public UnrealSharp.ControlRig.ERigElementType TypeToSearch;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionNameSearchArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionNameSearchArray");
        
        PartialName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PartialName");
        TypeToSearch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TypeToSearch");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionNameSearchArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            PartialName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PartialName_Offset), 0, null);
            TypeToSearch = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, TypeToSearch_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PartialName_Offset), 0, null, PartialName);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, TypeToSearch_Offset), 0, null, TypeToSearch);
        }
    }
}

public static class RigUnit_CollectionNameSearchArrayMarshaler
{
    public static RigUnit_CollectionNameSearchArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionNameSearchArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionNameSearchArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionNameSearchArray.NativeDataSize;
    }
}