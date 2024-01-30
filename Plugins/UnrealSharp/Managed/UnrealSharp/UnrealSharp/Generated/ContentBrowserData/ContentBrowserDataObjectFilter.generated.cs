using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UStruct]
public partial struct ContentBrowserDataObjectFilter
{
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataObjectFilter:bOnDiskObjectsOnly
    static readonly int bOnDiskObjectsOnly_Offset;
    public bool OnDiskObjectsOnly;
    
    
    public static readonly int NativeDataSize;
    static ContentBrowserDataObjectFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ContentBrowserDataObjectFilter");
        
        bOnDiskObjectsOnly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOnDiskObjectsOnly");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ContentBrowserDataObjectFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            OnDiskObjectsOnly = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOnDiskObjectsOnly_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOnDiskObjectsOnly_Offset), 0, null, OnDiskObjectsOnly);
        }
    }
}

public static class ContentBrowserDataObjectFilterMarshaler
{
    public static ContentBrowserDataObjectFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ContentBrowserDataObjectFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ContentBrowserDataObjectFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ContentBrowserDataObjectFilter.NativeDataSize;
    }
}