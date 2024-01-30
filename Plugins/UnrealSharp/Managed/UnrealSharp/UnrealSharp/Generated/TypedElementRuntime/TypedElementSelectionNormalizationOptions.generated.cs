using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TypedElementRuntime;

[UStruct]
public partial struct TypedElementSelectionNormalizationOptions
{
    // BoolProperty /Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions:bExpandGroups
    static readonly int bExpandGroups_Offset;
    public bool ExpandGroups;
    
    // BoolProperty /Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions:bFollowAttachment
    static readonly int bFollowAttachment_Offset;
    public bool FollowAttachment;
    
    
    public static readonly int NativeDataSize;
    static TypedElementSelectionNormalizationOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TypedElementSelectionNormalizationOptions");
        
        bExpandGroups_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExpandGroups");
        bFollowAttachment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFollowAttachment");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TypedElementSelectionNormalizationOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExpandGroups = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExpandGroups_Offset), 0, null);
            FollowAttachment = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFollowAttachment_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExpandGroups_Offset), 0, null, ExpandGroups);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFollowAttachment_Offset), 0, null, FollowAttachment);
        }
    }
}

public static class TypedElementSelectionNormalizationOptionsMarshaler
{
    public static TypedElementSelectionNormalizationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TypedElementSelectionNormalizationOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TypedElementSelectionNormalizationOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TypedElementSelectionNormalizationOptions.NativeDataSize;
    }
}