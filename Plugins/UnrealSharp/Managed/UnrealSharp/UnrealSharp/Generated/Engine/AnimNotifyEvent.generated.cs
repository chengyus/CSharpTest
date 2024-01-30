using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNotifyEvent
{
    // FloatProperty /Script/Engine.AnimNotifyEvent:TriggerWeightThreshold
    static readonly int TriggerWeightThreshold_Offset;
    public float TriggerWeightThreshold;
    
    // NameProperty /Script/Engine.AnimNotifyEvent:NotifyName
    static readonly int NotifyName_Offset;
    public Name NotifyName;
    
    // ObjectProperty /Script/Engine.AnimNotifyEvent:Notify
    static readonly int Notify_Offset;
    public UnrealSharp.Engine.AnimNotify Notify;
    
    // ObjectProperty /Script/Engine.AnimNotifyEvent:NotifyStateClass
    static readonly int NotifyStateClass_Offset;
    public UnrealSharp.Engine.AnimNotifyState NotifyStateClass;
    
    // ByteProperty /Script/Engine.AnimNotifyEvent:MontageTickType
    static readonly int MontageTickType_Offset;
    public UnrealSharp.Engine.EMontageNotifyTickType MontageTickType;
    
    // FloatProperty /Script/Engine.AnimNotifyEvent:NotifyTriggerChance
    static readonly int NotifyTriggerChance_Offset;
    public float NotifyTriggerChance;
    
    // ByteProperty /Script/Engine.AnimNotifyEvent:NotifyFilterType
    static readonly int NotifyFilterType_Offset;
    public UnrealSharp.Engine.ENotifyFilterType NotifyFilterType;
    
    // IntProperty /Script/Engine.AnimNotifyEvent:NotifyFilterLOD
    static readonly int NotifyFilterLOD_Offset;
    public int NotifyFilterLOD;
    
    // BoolProperty /Script/Engine.AnimNotifyEvent:bTriggerOnDedicatedServer
    static readonly int bTriggerOnDedicatedServer_Offset;
    public bool TriggerOnDedicatedServer;
    
    // BoolProperty /Script/Engine.AnimNotifyEvent:bTriggerOnFollower
    static readonly int bTriggerOnFollower_Offset;
    public bool TriggerOnFollower;
    
    
    public static readonly int NativeDataSize;
    static AnimNotifyEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNotifyEvent");
        
        TriggerWeightThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TriggerWeightThreshold");
        NotifyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NotifyName");
        Notify_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Notify");
        NotifyStateClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NotifyStateClass");
        MontageTickType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MontageTickType");
        NotifyTriggerChance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NotifyTriggerChance");
        NotifyFilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NotifyFilterType");
        NotifyFilterLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NotifyFilterLOD");
        bTriggerOnDedicatedServer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTriggerOnDedicatedServer");
        bTriggerOnFollower_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTriggerOnFollower");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNotifyEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            TriggerWeightThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TriggerWeightThreshold_Offset), 0, null);
            NotifyName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, NotifyName_Offset), 0, null);
            Notify = ObjectMarshaller<UnrealSharp.Engine.AnimNotify>.FromNative(IntPtr.Add(InNativeStruct, Notify_Offset), 0, null);
            NotifyStateClass = ObjectMarshaller<UnrealSharp.Engine.AnimNotifyState>.FromNative(IntPtr.Add(InNativeStruct, NotifyStateClass_Offset), 0, null);
            MontageTickType = BlittableMarshaller<UnrealSharp.Engine.EMontageNotifyTickType>.FromNative(IntPtr.Add(InNativeStruct, MontageTickType_Offset), 0, null);
            NotifyTriggerChance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NotifyTriggerChance_Offset), 0, null);
            NotifyFilterType = BlittableMarshaller<UnrealSharp.Engine.ENotifyFilterType>.FromNative(IntPtr.Add(InNativeStruct, NotifyFilterType_Offset), 0, null);
            NotifyFilterLOD = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NotifyFilterLOD_Offset), 0, null);
            TriggerOnDedicatedServer = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTriggerOnDedicatedServer_Offset), 0, null);
            TriggerOnFollower = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTriggerOnFollower_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TriggerWeightThreshold_Offset), 0, null, TriggerWeightThreshold);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, NotifyName_Offset), 0, null, NotifyName);
            ObjectMarshaller<UnrealSharp.Engine.AnimNotify>.ToNative(IntPtr.Add(Buffer, Notify_Offset), 0, null, Notify);
            ObjectMarshaller<UnrealSharp.Engine.AnimNotifyState>.ToNative(IntPtr.Add(Buffer, NotifyStateClass_Offset), 0, null, NotifyStateClass);
            BlittableMarshaller<UnrealSharp.Engine.EMontageNotifyTickType>.ToNative(IntPtr.Add(Buffer, MontageTickType_Offset), 0, null, MontageTickType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NotifyTriggerChance_Offset), 0, null, NotifyTriggerChance);
            BlittableMarshaller<UnrealSharp.Engine.ENotifyFilterType>.ToNative(IntPtr.Add(Buffer, NotifyFilterType_Offset), 0, null, NotifyFilterType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NotifyFilterLOD_Offset), 0, null, NotifyFilterLOD);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTriggerOnDedicatedServer_Offset), 0, null, TriggerOnDedicatedServer);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTriggerOnFollower_Offset), 0, null, TriggerOnFollower);
        }
    }
}

public static class AnimNotifyEventMarshaler
{
    public static AnimNotifyEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNotifyEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNotifyEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNotifyEvent.NativeDataSize;
    }
}