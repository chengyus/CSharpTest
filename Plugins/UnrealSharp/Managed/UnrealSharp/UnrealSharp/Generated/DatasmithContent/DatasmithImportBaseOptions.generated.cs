using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UStruct]
public partial struct DatasmithImportBaseOptions
{
    // EnumProperty /Script/DatasmithContent.DatasmithImportBaseOptions:SceneHandling
    static readonly int SceneHandling_Offset;
    public UnrealSharp.DatasmithContent.EDatasmithImportScene SceneHandling;
    
    // BoolProperty /Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeGeometry
    static readonly int bIncludeGeometry_Offset;
    public bool IncludeGeometry;
    
    // BoolProperty /Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeMaterial
    static readonly int bIncludeMaterial_Offset;
    public bool IncludeMaterial;
    
    // BoolProperty /Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeLight
    static readonly int bIncludeLight_Offset;
    public bool IncludeLight;
    
    // BoolProperty /Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeCamera
    static readonly int bIncludeCamera_Offset;
    public bool IncludeCamera;
    
    // BoolProperty /Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeAnimation
    static readonly int bIncludeAnimation_Offset;
    public bool IncludeAnimation;
    
    // StructProperty /Script/DatasmithContent.DatasmithImportBaseOptions:AssetOptions
    static readonly int AssetOptions_Offset;
    public UnrealSharp.DatasmithContent.DatasmithAssetImportOptions AssetOptions;
    
    // StructProperty /Script/DatasmithContent.DatasmithImportBaseOptions:StaticMeshOptions
    static readonly int StaticMeshOptions_Offset;
    public UnrealSharp.DatasmithContent.DatasmithStaticMeshImportOptions StaticMeshOptions;
    
    
    public static readonly int NativeDataSize;
    static DatasmithImportBaseOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DatasmithImportBaseOptions");
        
        SceneHandling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SceneHandling");
        bIncludeGeometry_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeGeometry");
        bIncludeMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeMaterial");
        bIncludeLight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeLight");
        bIncludeCamera_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeCamera");
        bIncludeAnimation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeAnimation");
        AssetOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetOptions");
        StaticMeshOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticMeshOptions");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DatasmithImportBaseOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            SceneHandling = BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithImportScene>.FromNative(IntPtr.Add(InNativeStruct, SceneHandling_Offset), 0, null);
            IncludeGeometry = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeGeometry_Offset), 0, null);
            IncludeMaterial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeMaterial_Offset), 0, null);
            IncludeLight = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeLight_Offset), 0, null);
            IncludeCamera = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeCamera_Offset), 0, null);
            IncludeAnimation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeAnimation_Offset), 0, null);
            AssetOptions = UnrealSharp.DatasmithContent.DatasmithAssetImportOptionsMarshaler.FromNative(IntPtr.Add(InNativeStruct, AssetOptions_Offset), 0, null);
            StaticMeshOptions = UnrealSharp.DatasmithContent.DatasmithStaticMeshImportOptionsMarshaler.FromNative(IntPtr.Add(InNativeStruct, StaticMeshOptions_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithImportScene>.ToNative(IntPtr.Add(Buffer, SceneHandling_Offset), 0, null, SceneHandling);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeGeometry_Offset), 0, null, IncludeGeometry);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeMaterial_Offset), 0, null, IncludeMaterial);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeLight_Offset), 0, null, IncludeLight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeCamera_Offset), 0, null, IncludeCamera);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeAnimation_Offset), 0, null, IncludeAnimation);
            UnrealSharp.DatasmithContent.DatasmithAssetImportOptionsMarshaler.ToNative(IntPtr.Add(Buffer, AssetOptions_Offset), 0, null, AssetOptions);
            UnrealSharp.DatasmithContent.DatasmithStaticMeshImportOptionsMarshaler.ToNative(IntPtr.Add(Buffer, StaticMeshOptions_Offset), 0, null, StaticMeshOptions);
        }
    }
}

public static class DatasmithImportBaseOptionsMarshaler
{
    public static DatasmithImportBaseOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DatasmithImportBaseOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DatasmithImportBaseOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DatasmithImportBaseOptions.NativeDataSize;
    }
}