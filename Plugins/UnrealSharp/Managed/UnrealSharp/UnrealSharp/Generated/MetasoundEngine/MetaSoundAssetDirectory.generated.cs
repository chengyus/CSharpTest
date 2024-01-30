using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundEngine;

[UStruct]
public partial struct MetaSoundAssetDirectory
{
    // StructProperty /Script/MetasoundEngine.MetaSoundAssetDirectory:Directory
    static readonly int Directory_Offset;
    public UnrealSharp.CoreUObject.DirectoryPath Directory;
    
    
    public static readonly int NativeDataSize;
    static MetaSoundAssetDirectory()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MetaSoundAssetDirectory");
        
        Directory_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Directory");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MetaSoundAssetDirectory(IntPtr InNativeStruct)
    {
        unsafe
        {
            Directory = UnrealSharp.CoreUObject.DirectoryPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, Directory_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.DirectoryPathMarshaler.ToNative(IntPtr.Add(Buffer, Directory_Offset), 0, null, Directory);
        }
    }
}

public static class MetaSoundAssetDirectoryMarshaler
{
    public static MetaSoundAssetDirectory FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MetaSoundAssetDirectory(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MetaSoundAssetDirectory obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MetaSoundAssetDirectory.NativeDataSize;
    }
}