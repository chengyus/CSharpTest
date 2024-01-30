using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ProgressBarStyle
{
    // StructProperty /Script/SlateCore.ProgressBarStyle:BackgroundImage
    static readonly int BackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImage;
    
    // StructProperty /Script/SlateCore.ProgressBarStyle:FillImage
    static readonly int FillImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush FillImage;
    
    // StructProperty /Script/SlateCore.ProgressBarStyle:MarqueeImage
    static readonly int MarqueeImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush MarqueeImage;
    
    // BoolProperty /Script/SlateCore.ProgressBarStyle:EnableFillAnimation
    static readonly int EnableFillAnimation_Offset;
    public bool EnableFillAnimation;
    
    
    public static readonly int NativeDataSize;
    static ProgressBarStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ProgressBarStyle");
        
        BackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImage");
        FillImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FillImage");
        MarqueeImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MarqueeImage");
        EnableFillAnimation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnableFillAnimation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ProgressBarStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            BackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImage_Offset), 0, null);
            FillImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, FillImage_Offset), 0, null);
            MarqueeImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MarqueeImage_Offset), 0, null);
            EnableFillAnimation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, EnableFillAnimation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImage_Offset), 0, null, BackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, FillImage_Offset), 0, null, FillImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MarqueeImage_Offset), 0, null, MarqueeImage);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, EnableFillAnimation_Offset), 0, null, EnableFillAnimation);
        }
    }
}

public static class ProgressBarStyleMarshaler
{
    public static ProgressBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ProgressBarStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ProgressBarStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ProgressBarStyle.NativeDataSize;
    }
}