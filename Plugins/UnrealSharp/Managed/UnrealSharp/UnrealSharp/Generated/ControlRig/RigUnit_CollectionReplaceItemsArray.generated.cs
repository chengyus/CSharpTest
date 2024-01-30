using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionReplaceItemsArray
{
    // NameProperty /Script/ControlRig.RigUnit_CollectionReplaceItemsArray:Old
    static readonly int Old_Offset;
    public Name Old;
    
    // NameProperty /Script/ControlRig.RigUnit_CollectionReplaceItemsArray:New
    static readonly int New_Offset;
    public Name New;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionReplaceItemsArray:RemoveInvalidItems
    static readonly int RemoveInvalidItems_Offset;
    public bool RemoveInvalidItems;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionReplaceItemsArray:bAllowDuplicates
    static readonly int bAllowDuplicates_Offset;
    public bool AllowDuplicates;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionReplaceItemsArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionReplaceItemsArray");
        
        Old_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Old");
        New_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "New");
        RemoveInvalidItems_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RemoveInvalidItems");
        bAllowDuplicates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowDuplicates");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionReplaceItemsArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Old = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Old_Offset), 0, null);
            New = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, New_Offset), 0, null);
            RemoveInvalidItems = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, RemoveInvalidItems_Offset), 0, null);
            AllowDuplicates = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowDuplicates_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Old_Offset), 0, null, Old);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, New_Offset), 0, null, New);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, RemoveInvalidItems_Offset), 0, null, RemoveInvalidItems);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowDuplicates_Offset), 0, null, AllowDuplicates);
        }
    }
}

public static class RigUnit_CollectionReplaceItemsArrayMarshaler
{
    public static RigUnit_CollectionReplaceItemsArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionReplaceItemsArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionReplaceItemsArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionReplaceItemsArray.NativeDataSize;
    }
}