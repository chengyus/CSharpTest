using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SynthKnobStyle
{
    // StructProperty /Script/Synthesis.SynthKnobStyle:LargeKnob
    static readonly int LargeKnob_Offset;
    public UnrealSharp.SlateCore.SlateBrush LargeKnob;
    
    // StructProperty /Script/Synthesis.SynthKnobStyle:LargeKnobOverlay
    static readonly int LargeKnobOverlay_Offset;
    public UnrealSharp.SlateCore.SlateBrush LargeKnobOverlay;
    
    // StructProperty /Script/Synthesis.SynthKnobStyle:MediumKnob
    static readonly int MediumKnob_Offset;
    public UnrealSharp.SlateCore.SlateBrush MediumKnob;
    
    // StructProperty /Script/Synthesis.SynthKnobStyle:MediumKnobOverlay
    static readonly int MediumKnobOverlay_Offset;
    public UnrealSharp.SlateCore.SlateBrush MediumKnobOverlay;
    
    // FloatProperty /Script/Synthesis.SynthKnobStyle:MinValueAngle
    static readonly int MinValueAngle_Offset;
    public float MinValueAngle;
    
    // FloatProperty /Script/Synthesis.SynthKnobStyle:MaxValueAngle
    static readonly int MaxValueAngle_Offset;
    public float MaxValueAngle;
    
    // EnumProperty /Script/Synthesis.SynthKnobStyle:KnobSize
    static readonly int KnobSize_Offset;
    public UnrealSharp.Synthesis.ESynthKnobSize KnobSize;
    
    
    public static readonly int NativeDataSize;
    static SynthKnobStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SynthKnobStyle");
        
        LargeKnob_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LargeKnob");
        LargeKnobOverlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LargeKnobOverlay");
        MediumKnob_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MediumKnob");
        MediumKnobOverlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MediumKnobOverlay");
        MinValueAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinValueAngle");
        MaxValueAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxValueAngle");
        KnobSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KnobSize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SynthKnobStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            LargeKnob = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, LargeKnob_Offset), 0, null);
            LargeKnobOverlay = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, LargeKnobOverlay_Offset), 0, null);
            MediumKnob = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MediumKnob_Offset), 0, null);
            MediumKnobOverlay = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MediumKnobOverlay_Offset), 0, null);
            MinValueAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinValueAngle_Offset), 0, null);
            MaxValueAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxValueAngle_Offset), 0, null);
            KnobSize = BlittableMarshaller<UnrealSharp.Synthesis.ESynthKnobSize>.FromNative(IntPtr.Add(InNativeStruct, KnobSize_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, LargeKnob_Offset), 0, null, LargeKnob);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, LargeKnobOverlay_Offset), 0, null, LargeKnobOverlay);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MediumKnob_Offset), 0, null, MediumKnob);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MediumKnobOverlay_Offset), 0, null, MediumKnobOverlay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinValueAngle_Offset), 0, null, MinValueAngle);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxValueAngle_Offset), 0, null, MaxValueAngle);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthKnobSize>.ToNative(IntPtr.Add(Buffer, KnobSize_Offset), 0, null, KnobSize);
        }
    }
}

public static class SynthKnobStyleMarshaler
{
    public static SynthKnobStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SynthKnobStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SynthKnobStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SynthKnobStyle.NativeDataSize;
    }
}