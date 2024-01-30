using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct]
public partial struct VersionedNiagaraEmitterData
{
    // BoolProperty /Script/Niagara.VersionedNiagaraEmitterData:bLocalSpace
    static readonly int bLocalSpace_Offset;
    public bool LocalSpace;
    
    // BoolProperty /Script/Niagara.VersionedNiagaraEmitterData:bDeterminism
    static readonly int bDeterminism_Offset;
    public bool Determinism;
    
    // IntProperty /Script/Niagara.VersionedNiagaraEmitterData:RandomSeed
    static readonly int RandomSeed_Offset;
    public int RandomSeed;
    
    // BoolProperty /Script/Niagara.VersionedNiagaraEmitterData:bInterpolatedSpawning
    static readonly int bInterpolatedSpawning_Offset;
    static readonly IntPtr bInterpolatedSpawning_NativeProperty;
    public bool InterpolatedSpawning;
    
    // EnumProperty /Script/Niagara.VersionedNiagaraEmitterData:SimTarget
    static readonly int SimTarget_Offset;
    public UnrealSharp.Niagara.ENiagaraSimTarget SimTarget;
    
    // StructProperty /Script/Niagara.VersionedNiagaraEmitterData:FixedBounds
    static readonly int FixedBounds_Offset;
    public UnrealSharp.CoreUObject.Box FixedBounds;
    
    // BoolProperty /Script/Niagara.VersionedNiagaraEmitterData:bRequiresPersistentIDs
    static readonly int bRequiresPersistentIDs_Offset;
    static readonly IntPtr bRequiresPersistentIDs_NativeProperty;
    public bool RequiresPersistentIDs;
    
    // IntProperty /Script/Niagara.VersionedNiagaraEmitterData:MaxGPUParticlesSpawnPerFrame
    static readonly int MaxGPUParticlesSpawnPerFrame_Offset;
    public int MaxGPUParticlesSpawnPerFrame;
    
    // EnumProperty /Script/Niagara.VersionedNiagaraEmitterData:AllocationMode
    static readonly int AllocationMode_Offset;
    public UnrealSharp.Niagara.EParticleAllocationMode AllocationMode;
    
    
    public static readonly int NativeDataSize;
    static VersionedNiagaraEmitterData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("VersionedNiagaraEmitterData");
        
        bLocalSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLocalSpace");
        bDeterminism_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDeterminism");
        RandomSeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RandomSeed");
        bInterpolatedSpawning_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInterpolatedSpawning");
        bInterpolatedSpawning_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bInterpolatedSpawning");
        SimTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SimTarget");
        FixedBounds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FixedBounds");
        bRequiresPersistentIDs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRequiresPersistentIDs");
        bRequiresPersistentIDs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRequiresPersistentIDs");
        MaxGPUParticlesSpawnPerFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxGPUParticlesSpawnPerFrame");
        AllocationMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AllocationMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public VersionedNiagaraEmitterData(IntPtr InNativeStruct)
    {
        unsafe
        {
            LocalSpace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLocalSpace_Offset), 0, null);
            Determinism = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDeterminism_Offset), 0, null);
            RandomSeed = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RandomSeed_Offset), 0, null);
            InterpolatedSpawning = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bInterpolatedSpawning_NativeProperty, bInterpolatedSpawning_Offset);
            SimTarget = BlittableMarshaller<UnrealSharp.Niagara.ENiagaraSimTarget>.FromNative(IntPtr.Add(InNativeStruct, SimTarget_Offset), 0, null);
            FixedBounds = UnrealSharp.CoreUObject.BoxMarshaler.FromNative(IntPtr.Add(InNativeStruct, FixedBounds_Offset), 0, null);
            RequiresPersistentIDs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRequiresPersistentIDs_NativeProperty, bRequiresPersistentIDs_Offset);
            MaxGPUParticlesSpawnPerFrame = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxGPUParticlesSpawnPerFrame_Offset), 0, null);
            AllocationMode = BlittableMarshaller<UnrealSharp.Niagara.EParticleAllocationMode>.FromNative(IntPtr.Add(InNativeStruct, AllocationMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLocalSpace_Offset), 0, null, LocalSpace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDeterminism_Offset), 0, null, Determinism);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RandomSeed_Offset), 0, null, RandomSeed);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bInterpolatedSpawning_NativeProperty, bInterpolatedSpawning_Offset, InterpolatedSpawning);
            BlittableMarshaller<UnrealSharp.Niagara.ENiagaraSimTarget>.ToNative(IntPtr.Add(Buffer, SimTarget_Offset), 0, null, SimTarget);
            UnrealSharp.CoreUObject.BoxMarshaler.ToNative(IntPtr.Add(Buffer, FixedBounds_Offset), 0, null, FixedBounds);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRequiresPersistentIDs_NativeProperty, bRequiresPersistentIDs_Offset, RequiresPersistentIDs);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxGPUParticlesSpawnPerFrame_Offset), 0, null, MaxGPUParticlesSpawnPerFrame);
            BlittableMarshaller<UnrealSharp.Niagara.EParticleAllocationMode>.ToNative(IntPtr.Add(Buffer, AllocationMode_Offset), 0, null, AllocationMode);
        }
    }
}

public static class VersionedNiagaraEmitterDataMarshaler
{
    public static VersionedNiagaraEmitterData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new VersionedNiagaraEmitterData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, VersionedNiagaraEmitterData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return VersionedNiagaraEmitterData.NativeDataSize;
    }
}