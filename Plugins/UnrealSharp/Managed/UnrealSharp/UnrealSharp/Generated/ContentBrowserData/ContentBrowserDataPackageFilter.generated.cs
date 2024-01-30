using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UStruct]
public partial struct ContentBrowserDataPackageFilter
{
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataPackageFilter:bRecursivePackagePathsToInclude
    static readonly int bRecursivePackagePathsToInclude_Offset;
    public bool RecursivePackagePathsToInclude;
    
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataPackageFilter:bRecursivePackagePathsToExclude
    static readonly int bRecursivePackagePathsToExclude_Offset;
    public bool RecursivePackagePathsToExclude;
    
    
    public static readonly int NativeDataSize;
    static ContentBrowserDataPackageFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ContentBrowserDataPackageFilter");
        
        bRecursivePackagePathsToInclude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursivePackagePathsToInclude");
        bRecursivePackagePathsToExclude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursivePackagePathsToExclude");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ContentBrowserDataPackageFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            RecursivePackagePathsToInclude = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursivePackagePathsToInclude_Offset), 0, null);
            RecursivePackagePathsToExclude = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursivePackagePathsToExclude_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursivePackagePathsToInclude_Offset), 0, null, RecursivePackagePathsToInclude);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursivePackagePathsToExclude_Offset), 0, null, RecursivePackagePathsToExclude);
        }
    }
}

public static class ContentBrowserDataPackageFilterMarshaler
{
    public static ContentBrowserDataPackageFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ContentBrowserDataPackageFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ContentBrowserDataPackageFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ContentBrowserDataPackageFilter.NativeDataSize;
    }
}