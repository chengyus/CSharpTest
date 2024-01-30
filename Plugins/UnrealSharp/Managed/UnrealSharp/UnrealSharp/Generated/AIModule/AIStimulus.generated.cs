using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct AIStimulus
{
    // FloatProperty /Script/AIModule.AIStimulus:Age
    static readonly int Age_Offset;
    public float Age;
    
    // FloatProperty /Script/AIModule.AIStimulus:ExpirationAge
    static readonly int ExpirationAge_Offset;
    public float ExpirationAge;
    
    // FloatProperty /Script/AIModule.AIStimulus:Strength
    static readonly int Strength_Offset;
    public float Strength;
    
    // StructProperty /Script/AIModule.AIStimulus:StimulusLocation
    static readonly int StimulusLocation_Offset;
    public System.DoubleNumerics.Vector3 StimulusLocation;
    
    // StructProperty /Script/AIModule.AIStimulus:ReceiverLocation
    static readonly int ReceiverLocation_Offset;
    public System.DoubleNumerics.Vector3 ReceiverLocation;
    
    // NameProperty /Script/AIModule.AIStimulus:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    // BoolProperty /Script/AIModule.AIStimulus:bSuccessfullySensed
    static readonly int bSuccessfullySensed_Offset;
    static readonly IntPtr bSuccessfullySensed_NativeProperty;
    public bool SuccessfullySensed;
    
    
    public static readonly int NativeDataSize;
    static AIStimulus()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AIStimulus");
        
        Age_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Age");
        ExpirationAge_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExpirationAge");
        Strength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Strength");
        StimulusLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StimulusLocation");
        ReceiverLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReceiverLocation");
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        bSuccessfullySensed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSuccessfullySensed");
        bSuccessfullySensed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSuccessfullySensed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AIStimulus(IntPtr InNativeStruct)
    {
        unsafe
        {
            Age = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Age_Offset), 0, null);
            ExpirationAge = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExpirationAge_Offset), 0, null);
            Strength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Strength_Offset), 0, null);
            StimulusLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, StimulusLocation_Offset), 0, null);
            ReceiverLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ReceiverLocation_Offset), 0, null);
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
            SuccessfullySensed = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSuccessfullySensed_NativeProperty, bSuccessfullySensed_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Age_Offset), 0, null, Age);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExpirationAge_Offset), 0, null, ExpirationAge);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Strength_Offset), 0, null, Strength);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, StimulusLocation_Offset), 0, null, StimulusLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ReceiverLocation_Offset), 0, null, ReceiverLocation);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSuccessfullySensed_NativeProperty, bSuccessfullySensed_Offset, SuccessfullySensed);
        }
    }
}

public static class AIStimulusMarshaler
{
    public static AIStimulus FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AIStimulus(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AIStimulus obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AIStimulus.NativeDataSize;
    }
}