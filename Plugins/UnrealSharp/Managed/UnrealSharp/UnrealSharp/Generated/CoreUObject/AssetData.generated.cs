using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct AssetData
{
    // NameProperty /Script/CoreUObject.AssetData:PackageName
    static readonly int PackageName_Offset;
    public Name PackageName;
    
    // NameProperty /Script/CoreUObject.AssetData:PackagePath
    static readonly int PackagePath_Offset;
    public Name PackagePath;
    
    // NameProperty /Script/CoreUObject.AssetData:AssetName
    static readonly int AssetName_Offset;
    public Name AssetName;
    
    // NameProperty /Script/CoreUObject.AssetData:AssetClass
    static readonly int AssetClass_Offset;
    public Name AssetClass;
    
    // StructProperty /Script/CoreUObject.AssetData:AssetClassPath
    static readonly int AssetClassPath_Offset;
    public UnrealSharp.CoreUObject.TopLevelAssetPath AssetClassPath;
    
    
    public static readonly int NativeDataSize;
    static AssetData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AssetData");
        
        PackageName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PackageName");
        PackagePath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PackagePath");
        AssetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetName");
        AssetClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetClass");
        AssetClassPath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetClassPath");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AssetData(IntPtr InNativeStruct)
    {
        unsafe
        {
            PackageName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PackageName_Offset), 0, null);
            PackagePath = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PackagePath_Offset), 0, null);
            AssetName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AssetName_Offset), 0, null);
            AssetClass = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AssetClass_Offset), 0, null);
            AssetClassPath = BlittableMarshaller<UnrealSharp.CoreUObject.TopLevelAssetPath>.FromNative(IntPtr.Add(InNativeStruct, AssetClassPath_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PackageName_Offset), 0, null, PackageName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PackagePath_Offset), 0, null, PackagePath);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AssetName_Offset), 0, null, AssetName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AssetClass_Offset), 0, null, AssetClass);
            BlittableMarshaller<UnrealSharp.CoreUObject.TopLevelAssetPath>.ToNative(IntPtr.Add(Buffer, AssetClassPath_Offset), 0, null, AssetClassPath);
        }
    }
}

public static class AssetDataMarshaler
{
    public static AssetData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AssetData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AssetData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AssetData.NativeDataSize;
    }
}