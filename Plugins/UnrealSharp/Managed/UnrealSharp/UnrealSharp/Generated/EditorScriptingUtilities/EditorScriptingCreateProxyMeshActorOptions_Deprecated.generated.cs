using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UStruct]
public partial struct EditorScriptingCreateProxyMeshActorOptions_Deprecated
{
    // BoolProperty /Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated:bSpawnMergedActor
    static readonly int bSpawnMergedActor_Offset;
    public bool SpawnMergedActor;
    
    // StructProperty /Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated:MeshProxySettings
    static readonly int MeshProxySettings_Offset;
    public UnrealSharp.Engine.MeshProxySettings MeshProxySettings;
    
    
    public static readonly int NativeDataSize;
    static EditorScriptingCreateProxyMeshActorOptions_Deprecated()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EditorScriptingCreateProxyMeshActorOptions_Deprecated");
        
        bSpawnMergedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpawnMergedActor");
        MeshProxySettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshProxySettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EditorScriptingCreateProxyMeshActorOptions_Deprecated(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpawnMergedActor = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSpawnMergedActor_Offset), 0, null);
            MeshProxySettings = UnrealSharp.Engine.MeshProxySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, MeshProxySettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSpawnMergedActor_Offset), 0, null, SpawnMergedActor);
            UnrealSharp.Engine.MeshProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, MeshProxySettings_Offset), 0, null, MeshProxySettings);
        }
    }
}

public static class EditorScriptingCreateProxyMeshActorOptions_DeprecatedMarshaler
{
    public static EditorScriptingCreateProxyMeshActorOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EditorScriptingCreateProxyMeshActorOptions_Deprecated(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EditorScriptingCreateProxyMeshActorOptions_Deprecated obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EditorScriptingCreateProxyMeshActorOptions_Deprecated.NativeDataSize;
    }
}