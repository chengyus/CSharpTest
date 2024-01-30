using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionChainArray
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionChainArray:FirstItem
    static readonly int FirstItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey FirstItem;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionChainArray:LastItem
    static readonly int LastItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey LastItem;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionChainArray:Reverse
    static readonly int Reverse_Offset;
    public bool Reverse;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionChainArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionChainArray");
        
        FirstItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstItem");
        LastItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LastItem");
        Reverse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Reverse");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionChainArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            FirstItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, FirstItem_Offset), 0, null);
            LastItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, LastItem_Offset), 0, null);
            Reverse = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Reverse_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, FirstItem_Offset), 0, null, FirstItem);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, LastItem_Offset), 0, null, LastItem);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Reverse_Offset), 0, null, Reverse);
        }
    }
}

public static class RigUnit_CollectionChainArrayMarshaler
{
    public static RigUnit_CollectionChainArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionChainArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionChainArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionChainArray.NativeDataSize;
    }
}