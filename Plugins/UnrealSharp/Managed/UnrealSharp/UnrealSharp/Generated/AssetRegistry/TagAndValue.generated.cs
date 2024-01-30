using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AssetRegistry;

[UStruct]
public partial struct TagAndValue
{
    // NameProperty /Script/AssetRegistry.TagAndValue:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    
    public static readonly int NativeDataSize;
    static TagAndValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TagAndValue");
        
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TagAndValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
        }
    }
}

public static class TagAndValueMarshaler
{
    public static TagAndValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TagAndValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TagAndValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TagAndValue.NativeDataSize;
    }
}