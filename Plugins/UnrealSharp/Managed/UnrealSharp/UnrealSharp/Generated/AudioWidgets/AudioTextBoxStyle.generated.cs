using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct AudioTextBoxStyle
{
    // StructProperty /Script/AudioWidgets.AudioTextBoxStyle:BackgroundImage
    static readonly int BackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImage;
    
    // StructProperty /Script/AudioWidgets.AudioTextBoxStyle:BackgroundColor
    static readonly int BackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor BackgroundColor;
    
    
    public static readonly int NativeDataSize;
    static AudioTextBoxStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioTextBoxStyle");
        
        BackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImage");
        BackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundColor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioTextBoxStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            BackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImage_Offset), 0, null);
            BackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundColor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImage_Offset), 0, null, BackgroundImage);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundColor_Offset), 0, null, BackgroundColor);
        }
    }
}

public static class AudioTextBoxStyleMarshaler
{
    public static AudioTextBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioTextBoxStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioTextBoxStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioTextBoxStyle.NativeDataSize;
    }
}