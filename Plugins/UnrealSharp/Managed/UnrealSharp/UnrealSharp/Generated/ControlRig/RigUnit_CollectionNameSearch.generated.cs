using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionNameSearch
{
    // NameProperty /Script/ControlRig.RigUnit_CollectionNameSearch:PartialName
    static readonly int PartialName_Offset;
    public Name PartialName;
    
    // EnumProperty /Script/ControlRig.RigUnit_CollectionNameSearch:TypeToSearch
    static readonly int TypeToSearch_Offset;
    public UnrealSharp.ControlRig.ERigElementType TypeToSearch;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionNameSearch:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionNameSearch()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionNameSearch");
        
        PartialName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PartialName");
        TypeToSearch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TypeToSearch");
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionNameSearch(IntPtr InNativeStruct)
    {
        unsafe
        {
            PartialName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PartialName_Offset), 0, null);
            TypeToSearch = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, TypeToSearch_Offset), 0, null);
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PartialName_Offset), 0, null, PartialName);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, TypeToSearch_Offset), 0, null, TypeToSearch);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
        }
    }
}

public static class RigUnit_CollectionNameSearchMarshaler
{
    public static RigUnit_CollectionNameSearch FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionNameSearch(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionNameSearch obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionNameSearch.NativeDataSize;
    }
}