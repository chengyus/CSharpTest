using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcStaticMeshSettings
{
    // BoolProperty /Script/AlembicLibrary.AbcStaticMeshSettings:bMergeMeshes
    static readonly int bMergeMeshes_Offset;
    public bool MergeMeshes;
    
    // BoolProperty /Script/AlembicLibrary.AbcStaticMeshSettings:bPropagateMatrixTransformations
    static readonly int bPropagateMatrixTransformations_Offset;
    public bool PropagateMatrixTransformations;
    
    // BoolProperty /Script/AlembicLibrary.AbcStaticMeshSettings:bGenerateLightmapUVs
    static readonly int bGenerateLightmapUVs_Offset;
    public bool GenerateLightmapUVs;
    
    
    public static readonly int NativeDataSize;
    static AbcStaticMeshSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcStaticMeshSettings");
        
        bMergeMeshes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMergeMeshes");
        bPropagateMatrixTransformations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateMatrixTransformations");
        bGenerateLightmapUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateLightmapUVs");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcStaticMeshSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MergeMeshes = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMergeMeshes_Offset), 0, null);
            PropagateMatrixTransformations = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateMatrixTransformations_Offset), 0, null);
            GenerateLightmapUVs = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bGenerateLightmapUVs_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMergeMeshes_Offset), 0, null, MergeMeshes);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateMatrixTransformations_Offset), 0, null, PropagateMatrixTransformations);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bGenerateLightmapUVs_Offset), 0, null, GenerateLightmapUVs);
        }
    }
}

public static class AbcStaticMeshSettingsMarshaler
{
    public static AbcStaticMeshSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcStaticMeshSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcStaticMeshSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcStaticMeshSettings.NativeDataSize;
    }
}