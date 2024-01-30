using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UStruct]
public partial struct EditorScriptingMergeStaticMeshActorsOptions_Deprecated
{
    // BoolProperty /Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated:bSpawnMergedActor
    static readonly int bSpawnMergedActor_Offset;
    public bool SpawnMergedActor;
    
    // StructProperty /Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated:MeshMergingSettings
    static readonly int MeshMergingSettings_Offset;
    public UnrealSharp.Engine.MeshMergingSettings MeshMergingSettings;
    
    
    public static readonly int NativeDataSize;
    static EditorScriptingMergeStaticMeshActorsOptions_Deprecated()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EditorScriptingMergeStaticMeshActorsOptions_Deprecated");
        
        bSpawnMergedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpawnMergedActor");
        MeshMergingSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshMergingSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EditorScriptingMergeStaticMeshActorsOptions_Deprecated(IntPtr InNativeStruct)
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

public static class EditorScriptingMergeStaticMeshActorsOptions_DeprecatedMarshaler
{
    public static EditorScriptingMergeStaticMeshActorsOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EditorScriptingMergeStaticMeshActorsOptions_Deprecated(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EditorScriptingMergeStaticMeshActorsOptions_Deprecated obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EditorScriptingMergeStaticMeshActorsOptions_Deprecated.NativeDataSize;
    }
}