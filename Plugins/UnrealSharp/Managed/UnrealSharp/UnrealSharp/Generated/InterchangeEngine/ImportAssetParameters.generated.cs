using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeEngine;

[UStruct]
public partial struct ImportAssetParameters
{
    // ObjectProperty /Script/InterchangeEngine.ImportAssetParameters:ReimportAsset
    static readonly int ReimportAsset_Offset;
    public UnrealSharp.CoreUObject.Object ReimportAsset;
    
    // IntProperty /Script/InterchangeEngine.ImportAssetParameters:ReimportSourceIndex
    static readonly int ReimportSourceIndex_Offset;
    public int ReimportSourceIndex;
    
    // BoolProperty /Script/InterchangeEngine.ImportAssetParameters:bIsAutomated
    static readonly int bIsAutomated_Offset;
    public bool IsAutomated;
    
    // BoolProperty /Script/InterchangeEngine.ImportAssetParameters:bFollowRedirectors
    static readonly int bFollowRedirectors_Offset;
    public bool FollowRedirectors;
    
    
    public static readonly int NativeDataSize;
    static ImportAssetParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ImportAssetParameters");
        
        ReimportAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReimportAsset");
        ReimportSourceIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReimportSourceIndex");
        bIsAutomated_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsAutomated");
        bFollowRedirectors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFollowRedirectors");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ImportAssetParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            ReimportAsset = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, ReimportAsset_Offset), 0, null);
            ReimportSourceIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ReimportSourceIndex_Offset), 0, null);
            IsAutomated = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsAutomated_Offset), 0, null);
            FollowRedirectors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFollowRedirectors_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, ReimportAsset_Offset), 0, null, ReimportAsset);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ReimportSourceIndex_Offset), 0, null, ReimportSourceIndex);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsAutomated_Offset), 0, null, IsAutomated);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFollowRedirectors_Offset), 0, null, FollowRedirectors);
        }
    }
}

public static class ImportAssetParametersMarshaler
{
    public static ImportAssetParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ImportAssetParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ImportAssetParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ImportAssetParameters.NativeDataSize;
    }
}