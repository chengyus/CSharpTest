using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AssetRegistry;

[UStruct]
public partial struct AssetRegistryDependencyOptions
{
    // BoolProperty /Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeSoftPackageReferences
    static readonly int bIncludeSoftPackageReferences_Offset;
    public bool IncludeSoftPackageReferences;
    
    // BoolProperty /Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeHardPackageReferences
    static readonly int bIncludeHardPackageReferences_Offset;
    public bool IncludeHardPackageReferences;
    
    // BoolProperty /Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeSearchableNames
    static readonly int bIncludeSearchableNames_Offset;
    public bool IncludeSearchableNames;
    
    // BoolProperty /Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeSoftManagementReferences
    static readonly int bIncludeSoftManagementReferences_Offset;
    public bool IncludeSoftManagementReferences;
    
    // BoolProperty /Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeHardManagementReferences
    static readonly int bIncludeHardManagementReferences_Offset;
    public bool IncludeHardManagementReferences;
    
    
    public static readonly int NativeDataSize;
    static AssetRegistryDependencyOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AssetRegistryDependencyOptions");
        
        bIncludeSoftPackageReferences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeSoftPackageReferences");
        bIncludeHardPackageReferences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeHardPackageReferences");
        bIncludeSearchableNames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeSearchableNames");
        bIncludeSoftManagementReferences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeSoftManagementReferences");
        bIncludeHardManagementReferences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeHardManagementReferences");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AssetRegistryDependencyOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            IncludeSoftPackageReferences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeSoftPackageReferences_Offset), 0, null);
            IncludeHardPackageReferences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeHardPackageReferences_Offset), 0, null);
            IncludeSearchableNames = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeSearchableNames_Offset), 0, null);
            IncludeSoftManagementReferences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeSoftManagementReferences_Offset), 0, null);
            IncludeHardManagementReferences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeHardManagementReferences_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeSoftPackageReferences_Offset), 0, null, IncludeSoftPackageReferences);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeHardPackageReferences_Offset), 0, null, IncludeHardPackageReferences);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeSearchableNames_Offset), 0, null, IncludeSearchableNames);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeSoftManagementReferences_Offset), 0, null, IncludeSoftManagementReferences);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeHardManagementReferences_Offset), 0, null, IncludeHardManagementReferences);
        }
    }
}

public static class AssetRegistryDependencyOptionsMarshaler
{
    public static AssetRegistryDependencyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AssetRegistryDependencyOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AssetRegistryDependencyOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AssetRegistryDependencyOptions.NativeDataSize;
    }
}