using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ButtonStyle
{
    // StructProperty /Script/SlateCore.ButtonStyle:Normal
    static readonly int Normal_Offset;
    public UnrealSharp.SlateCore.SlateBrush Normal;
    
    // StructProperty /Script/SlateCore.ButtonStyle:Hovered
    static readonly int Hovered_Offset;
    public UnrealSharp.SlateCore.SlateBrush Hovered;
    
    // StructProperty /Script/SlateCore.ButtonStyle:Pressed
    static readonly int Pressed_Offset;
    public UnrealSharp.SlateCore.SlateBrush Pressed;
    
    // StructProperty /Script/SlateCore.ButtonStyle:Disabled
    static readonly int Disabled_Offset;
    public UnrealSharp.SlateCore.SlateBrush Disabled;
    
    // StructProperty /Script/SlateCore.ButtonStyle:NormalForeground
    static readonly int NormalForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor NormalForeground;
    
    // StructProperty /Script/SlateCore.ButtonStyle:HoveredForeground
    static readonly int HoveredForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor HoveredForeground;
    
    // StructProperty /Script/SlateCore.ButtonStyle:PressedForeground
    static readonly int PressedForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor PressedForeground;
    
    // StructProperty /Script/SlateCore.ButtonStyle:DisabledForeground
    static readonly int DisabledForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor DisabledForeground;
    
    // StructProperty /Script/SlateCore.ButtonStyle:NormalPadding
    static readonly int NormalPadding_Offset;
    public UnrealSharp.SlateCore.Margin NormalPadding;
    
    // StructProperty /Script/SlateCore.ButtonStyle:PressedPadding
    static readonly int PressedPadding_Offset;
    public UnrealSharp.SlateCore.Margin PressedPadding;
    
    // StructProperty /Script/SlateCore.ButtonStyle:PressedSlateSound
    static readonly int PressedSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound PressedSlateSound;
    
    // StructProperty /Script/SlateCore.ButtonStyle:HoveredSlateSound
    static readonly int HoveredSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound HoveredSlateSound;
    
    
    public static readonly int NativeDataSize;
    static ButtonStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ButtonStyle");
        
        Normal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Normal");
        Hovered_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Hovered");
        Pressed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pressed");
        Disabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Disabled");
        NormalForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalForeground");
        HoveredForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredForeground");
        PressedForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PressedForeground");
        DisabledForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisabledForeground");
        NormalPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalPadding");
        PressedPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PressedPadding");
        PressedSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PressedSlateSound");
        HoveredSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredSlateSound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ButtonStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Normal = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, Normal_Offset), 0, null);
            Hovered = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, Hovered_Offset), 0, null);
            Pressed = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pressed_Offset), 0, null);
            Disabled = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, Disabled_Offset), 0, null);
            NormalForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, NormalForeground_Offset), 0, null);
            HoveredForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredForeground_Offset), 0, null);
            PressedForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, PressedForeground_Offset), 0, null);
            DisabledForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, DisabledForeground_Offset), 0, null);
            NormalPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, NormalPadding_Offset), 0, null);
            PressedPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, PressedPadding_Offset), 0, null);
            PressedSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, PressedSlateSound_Offset), 0, null);
            HoveredSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredSlateSound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, Normal_Offset), 0, null, Normal);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, Hovered_Offset), 0, null, Hovered);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, Pressed_Offset), 0, null, Pressed);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, Disabled_Offset), 0, null, Disabled);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, NormalForeground_Offset), 0, null, NormalForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, HoveredForeground_Offset), 0, null, HoveredForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, PressedForeground_Offset), 0, null, PressedForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, DisabledForeground_Offset), 0, null, DisabledForeground);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, NormalPadding_Offset), 0, null, NormalPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, PressedPadding_Offset), 0, null, PressedPadding);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, PressedSlateSound_Offset), 0, null, PressedSlateSound);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, HoveredSlateSound_Offset), 0, null, HoveredSlateSound);
        }
    }
}

public static class ButtonStyleMarshaler
{
    public static ButtonStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ButtonStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ButtonStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ButtonStyle.NativeDataSize;
    }
}