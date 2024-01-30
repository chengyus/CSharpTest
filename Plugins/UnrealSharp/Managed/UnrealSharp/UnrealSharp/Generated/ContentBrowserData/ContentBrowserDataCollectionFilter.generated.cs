using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UStruct]
public partial struct ContentBrowserDataCollectionFilter
{
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataCollectionFilter:bIncludeChildCollections
    static readonly int bIncludeChildCollections_Offset;
    public bool IncludeChildCollections;
    
    
    public static readonly int NativeDataSize;
    static ContentBrowserDataCollectionFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ContentBrowserDataCollectionFilter");
        
        bIncludeChildCollections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeChildCollections");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ContentBrowserDataCollectionFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            IncludeChildCollections = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeChildCollections_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeChildCollections_Offset), 0, null, IncludeChildCollections);
        }
    }
}

public static class ContentBrowserDataCollectionFilterMarshaler
{
    public static ContentBrowserDataCollectionFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ContentBrowserDataCollectionFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ContentBrowserDataCollectionFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ContentBrowserDataCollectionFilter.NativeDataSize;
    }
}