using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct ActorPerceptionBlueprintInfo
{
    // ObjectProperty /Script/AIModule.ActorPerceptionBlueprintInfo:Target
    static readonly int Target_Offset;
    public UnrealSharp.Engine.Actor Target;
    
    // BoolProperty /Script/AIModule.ActorPerceptionBlueprintInfo:bIsHostile
    static readonly int bIsHostile_Offset;
    static readonly IntPtr bIsHostile_NativeProperty;
    public bool IsHostile;
    
    
    public static readonly int NativeDataSize;
    static ActorPerceptionBlueprintInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ActorPerceptionBlueprintInfo");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        bIsHostile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsHostile");
        bIsHostile_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsHostile");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ActorPerceptionBlueprintInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            IsHostile = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsHostile_NativeProperty, bIsHostile_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsHostile_NativeProperty, bIsHostile_Offset, IsHostile);
        }
    }
}

public static class ActorPerceptionBlueprintInfoMarshaler
{
    public static ActorPerceptionBlueprintInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ActorPerceptionBlueprintInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ActorPerceptionBlueprintInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ActorPerceptionBlueprintInfo.NativeDataSize;
    }
}