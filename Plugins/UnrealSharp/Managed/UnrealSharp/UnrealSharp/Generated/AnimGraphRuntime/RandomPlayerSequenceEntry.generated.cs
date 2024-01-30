using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct RandomPlayerSequenceEntry
{
    // ObjectProperty /Script/AnimGraphRuntime.RandomPlayerSequenceEntry:Sequence
    static readonly int Sequence_Offset;
    public UnrealSharp.Engine.AnimSequenceBase Sequence;
    
    // FloatProperty /Script/AnimGraphRuntime.RandomPlayerSequenceEntry:ChanceToPlay
    static readonly int ChanceToPlay_Offset;
    public float ChanceToPlay;
    
    // IntProperty /Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MinLoopCount
    static readonly int MinLoopCount_Offset;
    public int MinLoopCount;
    
    // IntProperty /Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MaxLoopCount
    static readonly int MaxLoopCount_Offset;
    public int MaxLoopCount;
    
    // FloatProperty /Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MinPlayRate
    static readonly int MinPlayRate_Offset;
    public float MinPlayRate;
    
    // FloatProperty /Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MaxPlayRate
    static readonly int MaxPlayRate_Offset;
    public float MaxPlayRate;
    
    
    public static readonly int NativeDataSize;
    static RandomPlayerSequenceEntry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RandomPlayerSequenceEntry");
        
        Sequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sequence");
        ChanceToPlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChanceToPlay");
        MinLoopCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinLoopCount");
        MaxLoopCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxLoopCount");
        MinPlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinPlayRate");
        MaxPlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxPlayRate");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RandomPlayerSequenceEntry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sequence = ObjectMarshaller<UnrealSharp.Engine.AnimSequenceBase>.FromNative(IntPtr.Add(InNativeStruct, Sequence_Offset), 0, null);
            ChanceToPlay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChanceToPlay_Offset), 0, null);
            MinLoopCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MinLoopCount_Offset), 0, null);
            MaxLoopCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxLoopCount_Offset), 0, null);
            MinPlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinPlayRate_Offset), 0, null);
            MaxPlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxPlayRate_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.AnimSequenceBase>.ToNative(IntPtr.Add(Buffer, Sequence_Offset), 0, null, Sequence);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChanceToPlay_Offset), 0, null, ChanceToPlay);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MinLoopCount_Offset), 0, null, MinLoopCount);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxLoopCount_Offset), 0, null, MaxLoopCount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinPlayRate_Offset), 0, null, MinPlayRate);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxPlayRate_Offset), 0, null, MaxPlayRate);
        }
    }
}

public static class RandomPlayerSequenceEntryMarshaler
{
    public static RandomPlayerSequenceEntry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RandomPlayerSequenceEntry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RandomPlayerSequenceEntry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RandomPlayerSequenceEntry.NativeDataSize;
    }
}