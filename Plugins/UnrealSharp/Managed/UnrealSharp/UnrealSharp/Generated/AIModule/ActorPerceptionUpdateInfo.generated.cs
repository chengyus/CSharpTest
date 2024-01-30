using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct ActorPerceptionUpdateInfo
{
    // IntProperty /Script/AIModule.ActorPerceptionUpdateInfo:TargetId
    static readonly int TargetId_Offset;
    public int TargetId;
    
    // WeakObjectProperty /Script/AIModule.ActorPerceptionUpdateInfo:Target
    static readonly int Target_Offset;
    public WeakObject<UnrealSharp.Engine.Actor> Target;
    
    // StructProperty /Script/AIModule.ActorPerceptionUpdateInfo:Stimulus
    static readonly int Stimulus_Offset;
    public UnrealSharp.AIModule.AIStimulus Stimulus;
    
    
    public static readonly int NativeDataSize;
    static ActorPerceptionUpdateInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ActorPerceptionUpdateInfo");
        
        TargetId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetId");
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Stimulus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Stimulus");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ActorPerceptionUpdateInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetId = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, TargetId_Offset), 0, null);
            Target = BlittableMarshaller<WeakObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Stimulus = UnrealSharp.AIModule.AIStimulusMarshaler.FromNative(IntPtr.Add(InNativeStruct, Stimulus_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, TargetId_Offset), 0, null, TargetId);
            BlittableMarshaller<WeakObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            UnrealSharp.AIModule.AIStimulusMarshaler.ToNative(IntPtr.Add(Buffer, Stimulus_Offset), 0, null, Stimulus);
        }
    }
}

public static class ActorPerceptionUpdateInfoMarshaler
{
    public static ActorPerceptionUpdateInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ActorPerceptionUpdateInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ActorPerceptionUpdateInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ActorPerceptionUpdateInfo.NativeDataSize;
    }
}