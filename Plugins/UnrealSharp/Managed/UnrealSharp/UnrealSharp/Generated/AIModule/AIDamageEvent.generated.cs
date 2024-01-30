using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct AIDamageEvent
{
    // FloatProperty /Script/AIModule.AIDamageEvent:Amount
    static readonly int Amount_Offset;
    public float Amount;
    
    // StructProperty /Script/AIModule.AIDamageEvent:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/AIModule.AIDamageEvent:HitLocation
    static readonly int HitLocation_Offset;
    public System.DoubleNumerics.Vector3 HitLocation;
    
    // ObjectProperty /Script/AIModule.AIDamageEvent:DamagedActor
    static readonly int DamagedActor_Offset;
    public UnrealSharp.Engine.Actor DamagedActor;
    
    // ObjectProperty /Script/AIModule.AIDamageEvent:Instigator
    static readonly int Instigator_Offset;
    public UnrealSharp.Engine.Actor Instigator;
    
    // NameProperty /Script/AIModule.AIDamageEvent:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    
    public static readonly int NativeDataSize;
    static AIDamageEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AIDamageEvent");
        
        Amount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Amount");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        HitLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitLocation");
        DamagedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DamagedActor");
        Instigator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Instigator");
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AIDamageEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Amount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Amount_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            HitLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, HitLocation_Offset), 0, null);
            DamagedActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, DamagedActor_Offset), 0, null);
            Instigator = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, Instigator_Offset), 0, null);
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Amount_Offset), 0, null, Amount);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, HitLocation_Offset), 0, null, HitLocation);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, DamagedActor_Offset), 0, null, DamagedActor);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, Instigator_Offset), 0, null, Instigator);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
        }
    }
}

public static class AIDamageEventMarshaler
{
    public static AIDamageEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AIDamageEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AIDamageEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AIDamageEvent.NativeDataSize;
    }
}