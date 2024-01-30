using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshEditor;

[UStruct]
public partial struct MergeStaticMeshActorsOptions
{
    // BoolProperty /Script/StaticMeshEditor.MergeStaticMeshActorsOptions:bSpawnMergedActor
    static readonly int bSpawnMergedActor_Offset;
    public bool SpawnMergedActor;
    
    // StructProperty /Script/StaticMeshEditor.MergeStaticMeshActorsOptions:MeshMergingSettings
    static readonly int MeshMergingSettings_Offset;
    public UnrealSharp.Engine.MeshMergingSettings MeshMergingSettings;
    
    
    public static readonly int NativeDataSize;
    static MergeStaticMeshActorsOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MergeStaticMeshActorsOptions");
        
        bSpawnMergedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpawnMergedActor");
        MeshMergingSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshMergingSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MergeStaticMeshActorsOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpawnMergedActor = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSpawnMergedActor_Offset), 0, null);
            MeshMergingSettings = UnrealSharp.Engine.MeshMergingSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, MeshMergingSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSpawnMergedActor_Offset), 0, null, SpawnMergedActor);
            UnrealSharp.Engine.MeshMergingSettingsMarshaler.ToNative(IntPtr.Add(Buffer, MeshMergingSettings_Offset), 0, null, MeshMergingSettings);
        }
    }
}

public static class MergeStaticMeshActorsOptionsMarshaler
{
    public static MergeStaticMeshActorsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MergeStaticMeshActorsOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MergeStaticMeshActorsOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MergeStaticMeshActorsOptions.NativeDataSize;
    }
}