using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshEditor;

[UStruct]
public partial struct CreateProxyMeshActorOptions
{
    // BoolProperty /Script/StaticMeshEditor.CreateProxyMeshActorOptions:bSpawnMergedActor
    static readonly int bSpawnMergedActor_Offset;
    public bool SpawnMergedActor;
    
    // StructProperty /Script/StaticMeshEditor.CreateProxyMeshActorOptions:MeshProxySettings
    static readonly int MeshProxySettings_Offset;
    public UnrealSharp.Engine.MeshProxySettings MeshProxySettings;
    
    
    public static readonly int NativeDataSize;
    static CreateProxyMeshActorOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CreateProxyMeshActorOptions");
        
        bSpawnMergedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpawnMergedActor");
        MeshProxySettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshProxySettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CreateProxyMeshActorOptions(IntPtr InNativeStruct)
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

public static class CreateProxyMeshActorOptionsMarshaler
{
    public static CreateProxyMeshActorOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CreateProxyMeshActorOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CreateProxyMeshActorOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CreateProxyMeshActorOptions.NativeDataSize;
    }
}