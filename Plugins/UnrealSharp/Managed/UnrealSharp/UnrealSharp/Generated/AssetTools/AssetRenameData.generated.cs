using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AssetTools;

[UStruct]
public partial struct AssetRenameData
{
    // WeakObjectProperty /Script/AssetTools.AssetRenameData:Asset
    static readonly int Asset_Offset;
    public WeakObject<UnrealSharp.CoreUObject.Object> Asset;
    
    
    public static readonly int NativeDataSize;
    static AssetRenameData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AssetRenameData");
        
        Asset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Asset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AssetRenameData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Asset = BlittableMarshaller<WeakObject<UnrealSharp.CoreUObject.Object>>.FromNative(IntPtr.Add(InNativeStruct, Asset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<WeakObject<UnrealSharp.CoreUObject.Object>>.ToNative(IntPtr.Add(Buffer, Asset_Offset), 0, null, Asset);
        }
    }
}

public static class AssetRenameDataMarshaler
{
    public static AssetRenameData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AssetRenameData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AssetRenameData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AssetRenameData.NativeDataSize;
    }
}