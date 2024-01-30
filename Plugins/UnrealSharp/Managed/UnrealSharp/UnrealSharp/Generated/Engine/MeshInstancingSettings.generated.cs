using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshInstancingSettings
{
    // ClassProperty /Script/Engine.MeshInstancingSettings:ActorClassToUse
    static readonly int ActorClassToUse_Offset;
    public SubclassOf<UnrealSharp.Engine.Actor> ActorClassToUse;
    
    // IntProperty /Script/Engine.MeshInstancingSettings:InstanceReplacementThreshold
    static readonly int InstanceReplacementThreshold_Offset;
    public int InstanceReplacementThreshold;
    
    // BoolProperty /Script/Engine.MeshInstancingSettings:bSkipMeshesWithVertexColors
    static readonly int bSkipMeshesWithVertexColors_Offset;
    public bool SkipMeshesWithVertexColors;
    
    // BoolProperty /Script/Engine.MeshInstancingSettings:bUseHLODVolumes
    static readonly int bUseHLODVolumes_Offset;
    public bool UseHLODVolumes;
    
    // ClassProperty /Script/Engine.MeshInstancingSettings:ISMComponentToUse
    static readonly int ISMComponentToUse_Offset;
    public SubclassOf<UnrealSharp.Engine.InstancedStaticMeshComponent> ISMComponentToUse;
    
    
    public static readonly int NativeDataSize;
    static MeshInstancingSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshInstancingSettings");
        
        ActorClassToUse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActorClassToUse");
        InstanceReplacementThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InstanceReplacementThreshold");
        bSkipMeshesWithVertexColors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipMeshesWithVertexColors");
        bUseHLODVolumes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseHLODVolumes");
        ISMComponentToUse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ISMComponentToUse");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshInstancingSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ActorClassToUse = SubclassOfMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, ActorClassToUse_Offset), 0, null);
            InstanceReplacementThreshold = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InstanceReplacementThreshold_Offset), 0, null);
            SkipMeshesWithVertexColors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipMeshesWithVertexColors_Offset), 0, null);
            UseHLODVolumes = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseHLODVolumes_Offset), 0, null);
            ISMComponentToUse = SubclassOfMarshaller<UnrealSharp.Engine.InstancedStaticMeshComponent>.FromNative(IntPtr.Add(InNativeStruct, ISMComponentToUse_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, ActorClassToUse_Offset), 0, null, ActorClassToUse);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InstanceReplacementThreshold_Offset), 0, null, InstanceReplacementThreshold);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipMeshesWithVertexColors_Offset), 0, null, SkipMeshesWithVertexColors);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseHLODVolumes_Offset), 0, null, UseHLODVolumes);
            SubclassOfMarshaller<UnrealSharp.Engine.InstancedStaticMeshComponent>.ToNative(IntPtr.Add(Buffer, ISMComponentToUse_Offset), 0, null, ISMComponentToUse);
        }
    }
}

public static class MeshInstancingSettingsMarshaler
{
    public static MeshInstancingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshInstancingSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshInstancingSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshInstancingSettings.NativeDataSize;
    }
}