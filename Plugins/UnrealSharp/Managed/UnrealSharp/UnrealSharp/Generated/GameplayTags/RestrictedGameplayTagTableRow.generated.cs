using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayTags;

[UStruct]
public partial struct RestrictedGameplayTagTableRow
{
    // BoolProperty /Script/GameplayTags.RestrictedGameplayTagTableRow:bAllowNonRestrictedChildren
    static readonly int bAllowNonRestrictedChildren_Offset;
    public bool AllowNonRestrictedChildren;
    
    
    public static readonly int NativeDataSize;
    static RestrictedGameplayTagTableRow()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RestrictedGameplayTagTableRow");
        
        bAllowNonRestrictedChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowNonRestrictedChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RestrictedGameplayTagTableRow(IntPtr InNativeStruct)
    {
        unsafe
        {
            AllowNonRestrictedChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowNonRestrictedChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowNonRestrictedChildren_Offset), 0, null, AllowNonRestrictedChildren);
        }
    }
}

public static class RestrictedGameplayTagTableRowMarshaler
{
    public static RestrictedGameplayTagTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RestrictedGameplayTagTableRow(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RestrictedGameplayTagTableRow obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RestrictedGameplayTagTableRow.NativeDataSize;
    }
}