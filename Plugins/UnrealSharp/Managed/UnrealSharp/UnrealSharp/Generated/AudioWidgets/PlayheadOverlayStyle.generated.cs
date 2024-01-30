using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct PlayheadOverlayStyle
{
    // StructProperty /Script/AudioWidgets.PlayheadOverlayStyle:PlayheadColor
    static readonly int PlayheadColor_Offset;
    public UnrealSharp.SlateCore.SlateColor PlayheadColor;
    
    // FloatProperty /Script/AudioWidgets.PlayheadOverlayStyle:PlayheadWidth
    static readonly int PlayheadWidth_Offset;
    public float PlayheadWidth;
    
    // FloatProperty /Script/AudioWidgets.PlayheadOverlayStyle:DesiredWidth
    static readonly int DesiredWidth_Offset;
    public float DesiredWidth;
    
    // FloatProperty /Script/AudioWidgets.PlayheadOverlayStyle:DesiredHeight
    static readonly int DesiredHeight_Offset;
    public float DesiredHeight;
    
    
    public static readonly int NativeDataSize;
    static PlayheadOverlayStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PlayheadOverlayStyle");
        
        PlayheadColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayheadColor");
        PlayheadWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayheadWidth");
        DesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredWidth");
        DesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredHeight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PlayheadOverlayStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            PlayheadColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, PlayheadColor_Offset), 0, null);
            PlayheadWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlayheadWidth_Offset), 0, null);
            DesiredWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DesiredWidth_Offset), 0, null);
            DesiredHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DesiredHeight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, PlayheadColor_Offset), 0, null, PlayheadColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlayheadWidth_Offset), 0, null, PlayheadWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredWidth_Offset), 0, null, DesiredWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredHeight_Offset), 0, null, DesiredHeight);
        }
    }
}

public static class PlayheadOverlayStyleMarshaler
{
    public static PlayheadOverlayStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PlayheadOverlayStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PlayheadOverlayStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PlayheadOverlayStyle.NativeDataSize;
    }
}