using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct AITestSpawnInfoBase
{
    // ObjectProperty /Script/FunctionalTesting.AITestSpawnInfoBase:SpawnLocation
    static readonly int SpawnLocation_Offset;
    public UnrealSharp.Engine.Actor SpawnLocation;
    
    // IntProperty /Script/FunctionalTesting.AITestSpawnInfoBase:NumberToSpawn
    static readonly int NumberToSpawn_Offset;
    public int NumberToSpawn;
    
    // FloatProperty /Script/FunctionalTesting.AITestSpawnInfoBase:SpawnDelay
    static readonly int SpawnDelay_Offset;
    public float SpawnDelay;
    
    // FloatProperty /Script/FunctionalTesting.AITestSpawnInfoBase:PreSpawnDelay
    static readonly int PreSpawnDelay_Offset;
    public float PreSpawnDelay;
    
    
    public static readonly int NativeDataSize;
    static AITestSpawnInfoBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AITestSpawnInfoBase");
        
        SpawnLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpawnLocation");
        NumberToSpawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumberToSpawn");
        SpawnDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpawnDelay");
        PreSpawnDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreSpawnDelay");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AITestSpawnInfoBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpawnLocation = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, SpawnLocation_Offset), 0, null);
            NumberToSpawn = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumberToSpawn_Offset), 0, null);
            SpawnDelay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpawnDelay_Offset), 0, null);
            PreSpawnDelay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PreSpawnDelay_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, SpawnLocation_Offset), 0, null, SpawnLocation);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumberToSpawn_Offset), 0, null, NumberToSpawn);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpawnDelay_Offset), 0, null, SpawnDelay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PreSpawnDelay_Offset), 0, null, PreSpawnDelay);
        }
    }
}

public static class AITestSpawnInfoBaseMarshaler
{
    public static AITestSpawnInfoBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AITestSpawnInfoBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AITestSpawnInfoBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AITestSpawnInfoBase.NativeDataSize;
    }
}