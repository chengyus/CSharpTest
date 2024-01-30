using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UStruct]
public partial struct ContentBrowserDataClassFilter
{
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataClassFilter:bRecursiveClassNamesToInclude
    static readonly int bRecursiveClassNamesToInclude_Offset;
    public bool RecursiveClassNamesToInclude;
    
    // BoolProperty /Script/ContentBrowserData.ContentBrowserDataClassFilter:bRecursiveClassNamesToExclude
    static readonly int bRecursiveClassNamesToExclude_Offset;
    public bool RecursiveClassNamesToExclude;
    
    
    public static readonly int NativeDataSize;
    static ContentBrowserDataClassFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ContentBrowserDataClassFilter");
        
        bRecursiveClassNamesToInclude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursiveClassNamesToInclude");
        bRecursiveClassNamesToExclude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursiveClassNamesToExclude");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ContentBrowserDataClassFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            RecursiveClassNamesToInclude = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursiveClassNamesToInclude_Offset), 0, null);
            RecursiveClassNamesToExclude = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursiveClassNamesToExclude_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursiveClassNamesToInclude_Offset), 0, null, RecursiveClassNamesToInclude);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursiveClassNamesToExclude_Offset), 0, null, RecursiveClassNamesToExclude);
        }
    }
}

public static class ContentBrowserDataClassFilterMarshaler
{
    public static ContentBrowserDataClassFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ContentBrowserDataClassFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ContentBrowserDataClassFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ContentBrowserDataClassFilter.NativeDataSize;
    }
}