using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct AINoiseEvent
{
    // StructProperty /Script/AIModule.AINoiseEvent:NoiseLocation
    static readonly int NoiseLocation_Offset;
    public System.DoubleNumerics.Vector3 NoiseLocation;
    
    // FloatProperty /Script/AIModule.AINoiseEvent:Loudness
    static readonly int Loudness_Offset;
    public float Loudness;
    
    // FloatProperty /Script/AIModule.AINoiseEvent:MaxRange
    static readonly int MaxRange_Offset;
    public float MaxRange;
    
    // ObjectProperty /Script/AIModule.AINoiseEvent:Instigator
    static readonly int Instigator_Offset;
    public UnrealSharp.Engine.Actor Instigator;
    
    // NameProperty /Script/AIModule.AINoiseEvent:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    
    public static readonly int NativeDataSize;
    static AINoiseEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AINoiseEvent");
        
        NoiseLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NoiseLocation");
        Loudness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Loudness");
        MaxRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxRange");
        Instigator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Instigator");
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AINoiseEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            NoiseLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, NoiseLocation_Offset), 0, null);
            Loudness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Loudness_Offset), 0, null);
            MaxRange = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxRange_Offset), 0, null);
            Instigator = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, Instigator_Offset), 0, null);
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, NoiseLocation_Offset), 0, null, NoiseLocation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Loudness_Offset), 0, null, Loudness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxRange_Offset), 0, null, MaxRange);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, Instigator_Offset), 0, null, Instigator);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
        }
    }
}

public static class AINoiseEventMarshaler
{
    public static AINoiseEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AINoiseEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AINoiseEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AINoiseEvent.NativeDataSize;
    }
}