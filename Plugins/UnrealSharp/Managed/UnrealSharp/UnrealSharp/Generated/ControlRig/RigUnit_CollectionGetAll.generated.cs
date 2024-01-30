using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionGetAll
{
    // EnumProperty /Script/ControlRig.RigUnit_CollectionGetAll:TypeToSearch
    static readonly int TypeToSearch_Offset;
    public UnrealSharp.ControlRig.ERigElementType TypeToSearch;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionGetAll()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionGetAll");
        
        TypeToSearch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TypeToSearch");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionGetAll(IntPtr InNativeStruct)
    {
        unsafe
        {
            TypeToSearch = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, TypeToSearch_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, TypeToSearch_Offset), 0, null, TypeToSearch);
        }
    }
}

public static class RigUnit_CollectionGetAllMarshaler
{
    public static RigUnit_CollectionGetAll FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionGetAll(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionGetAll obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionGetAll.NativeDataSize;
    }
}