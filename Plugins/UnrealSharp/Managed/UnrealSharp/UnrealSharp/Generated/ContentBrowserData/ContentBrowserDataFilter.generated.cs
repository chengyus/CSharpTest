using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UStruct]
public partial struct ContentBrowserDataFilter
{
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataFilter:bRecursivePaths
    static readonly int bRecursivePaths_Offset;
    public bool RecursivePaths;
    
    // EnumProperty /Script/ContentBrowserData.ContentBrowserDataFilter:ItemTypeFilter
    static readonly int ItemTypeFilter_Offset;
    public UnrealSharp.ContentBrowserData.EContentBrowserItemTypeFilter ItemTypeFilter;
    
    // EnumProperty /Script/ContentBrowserData.ContentBrowserDataFilter:ItemCategoryFilter
    static readonly int ItemCategoryFilter_Offset;
    public UnrealSharp.ContentBrowserData.EContentBrowserItemCategoryFilter ItemCategoryFilter;
    
    // EnumProperty /Script/ContentBrowserData.ContentBrowserDataFilter:ItemAttributeFilter
    static readonly int ItemAttributeFilter_Offset;
    public UnrealSharp.ContentBrowserData.EContentBrowserItemAttributeFilter ItemAttributeFilter;
    
    
    public static readonly int NativeDataSize;
    static ContentBrowserDataFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ContentBrowserDataFilter");
        
        bRecursivePaths_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursivePaths");
        ItemTypeFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemTypeFilter");
        ItemCategoryFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemCategoryFilter");
        ItemAttributeFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemAttributeFilter");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ContentBrowserDataFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            RecursivePaths = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursivePaths_Offset), 0, null);
            ItemTypeFilter = BlittableMarshaller<UnrealSharp.ContentBrowserData.EContentBrowserItemTypeFilter>.FromNative(IntPtr.Add(InNativeStruct, ItemTypeFilter_Offset), 0, null);
            ItemCategoryFilter = BlittableMarshaller<UnrealSharp.ContentBrowserData.EContentBrowserItemCategoryFilter>.FromNative(IntPtr.Add(InNativeStruct, ItemCategoryFilter_Offset), 0, null);
            ItemAttributeFilter = BlittableMarshaller<UnrealSharp.ContentBrowserData.EContentBrowserItemAttributeFilter>.FromNative(IntPtr.Add(InNativeStruct, ItemAttributeFilter_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursivePaths_Offset), 0, null, RecursivePaths);
            BlittableMarshaller<UnrealSharp.ContentBrowserData.EContentBrowserItemTypeFilter>.ToNative(IntPtr.Add(Buffer, ItemTypeFilter_Offset), 0, null, ItemTypeFilter);
            BlittableMarshaller<UnrealSharp.ContentBrowserData.EContentBrowserItemCategoryFilter>.ToNative(IntPtr.Add(Buffer, ItemCategoryFilter_Offset), 0, null, ItemCategoryFilter);
            BlittableMarshaller<UnrealSharp.ContentBrowserData.EContentBrowserItemAttributeFilter>.ToNative(IntPtr.Add(Buffer, ItemAttributeFilter_Offset), 0, null, ItemAttributeFilter);
        }
    }
}

public static class ContentBrowserDataFilterMarshaler
{
    public static ContentBrowserDataFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ContentBrowserDataFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ContentBrowserDataFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ContentBrowserDataFilter.NativeDataSize;
    }
}