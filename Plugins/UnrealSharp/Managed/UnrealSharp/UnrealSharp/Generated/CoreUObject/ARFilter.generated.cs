using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct ARFilter
{
    // BoolProperty /Script/CoreUObject.ARFilter:bRecursivePaths
    static readonly int bRecursivePaths_Offset;
    public bool RecursivePaths;
    
    // BoolProperty /Script/CoreUObject.ARFilter:bRecursiveClasses
    static readonly int bRecursiveClasses_Offset;
    public bool RecursiveClasses;
    
    // BoolProperty /Script/CoreUObject.ARFilter:bIncludeOnlyOnDiskAssets
    static readonly int bIncludeOnlyOnDiskAssets_Offset;
    public bool IncludeOnlyOnDiskAssets;
    
    
    public static readonly int NativeDataSize;
    static ARFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ARFilter");
        
        bRecursivePaths_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursivePaths");
        bRecursiveClasses_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursiveClasses");
        bIncludeOnlyOnDiskAssets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeOnlyOnDiskAssets");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ARFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            RecursivePaths = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursivePaths_Offset), 0, null);
            RecursiveClasses = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursiveClasses_Offset), 0, null);
            IncludeOnlyOnDiskAssets = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeOnlyOnDiskAssets_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursivePaths_Offset), 0, null, RecursivePaths);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursiveClasses_Offset), 0, null, RecursiveClasses);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeOnlyOnDiskAssets_Offset), 0, null, IncludeOnlyOnDiskAssets);
        }
    }
}

public static class ARFilterMarshaler
{
    public static ARFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ARFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ARFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ARFilter.NativeDataSize;
    }
}