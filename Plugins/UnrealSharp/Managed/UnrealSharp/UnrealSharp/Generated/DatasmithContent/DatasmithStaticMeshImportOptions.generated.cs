using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UStruct]
public partial struct DatasmithStaticMeshImportOptions
{
    // EnumProperty /Script/DatasmithContent.DatasmithStaticMeshImportOptions:MinLightmapResolution
    static readonly int MinLightmapResolution_Offset;
    public UnrealSharp.DatasmithContent.EDatasmithImportLightmapMin MinLightmapResolution;
    
    // EnumProperty /Script/DatasmithContent.DatasmithStaticMeshImportOptions:MaxLightmapResolution
    static readonly int MaxLightmapResolution_Offset;
    public UnrealSharp.DatasmithContent.EDatasmithImportLightmapMax MaxLightmapResolution;
    
    // BoolProperty /Script/DatasmithContent.DatasmithStaticMeshImportOptions:bGenerateLightmapUVs
    static readonly int bGenerateLightmapUVs_Offset;
    public bool GenerateLightmapUVs;
    
    // BoolProperty /Script/DatasmithContent.DatasmithStaticMeshImportOptions:bRemoveDegenerates
    static readonly int bRemoveDegenerates_Offset;
    public bool RemoveDegenerates;
    
    
    public static readonly int NativeDataSize;
    static DatasmithStaticMeshImportOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DatasmithStaticMeshImportOptions");
        
        MinLightmapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinLightmapResolution");
        MaxLightmapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxLightmapResolution");
        bGenerateLightmapUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateLightmapUVs");
        bRemoveDegenerates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRemoveDegenerates");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DatasmithStaticMeshImportOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            MinLightmapResolution = BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithImportLightmapMin>.FromNative(IntPtr.Add(InNativeStruct, MinLightmapResolution_Offset), 0, null);
            MaxLightmapResolution = BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithImportLightmapMax>.FromNative(IntPtr.Add(InNativeStruct, MaxLightmapResolution_Offset), 0, null);
            GenerateLightmapUVs = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bGenerateLightmapUVs_Offset), 0, null);
            RemoveDegenerates = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRemoveDegenerates_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithImportLightmapMin>.ToNative(IntPtr.Add(Buffer, MinLightmapResolution_Offset), 0, null, MinLightmapResolution);
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithImportLightmapMax>.ToNative(IntPtr.Add(Buffer, MaxLightmapResolution_Offset), 0, null, MaxLightmapResolution);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bGenerateLightmapUVs_Offset), 0, null, GenerateLightmapUVs);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRemoveDegenerates_Offset), 0, null, RemoveDegenerates);
        }
    }
}

public static class DatasmithStaticMeshImportOptionsMarshaler
{
    public static DatasmithStaticMeshImportOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DatasmithStaticMeshImportOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DatasmithStaticMeshImportOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DatasmithStaticMeshImportOptions.NativeDataSize;
    }
}