using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SlateColor
{
    // StructProperty /Script/SlateCore.SlateColor:SpecifiedColor
    static readonly int SpecifiedColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor SpecifiedColor;
    
    // EnumProperty /Script/SlateCore.SlateColor:ColorUseRule
    static readonly int ColorUseRule_Offset;
    public UnrealSharp.SlateCore.ESlateColorStylingMode ColorUseRule;
    
    
    public static readonly int NativeDataSize;
    static SlateColor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SlateColor");
        
        SpecifiedColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpecifiedColor");
        ColorUseRule_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorUseRule");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SlateColor(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpecifiedColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, SpecifiedColor_Offset), 0, null);
            ColorUseRule = BlittableMarshaller<UnrealSharp.SlateCore.ESlateColorStylingMode>.FromNative(IntPtr.Add(InNativeStruct, ColorUseRule_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, SpecifiedColor_Offset), 0, null, SpecifiedColor);
            BlittableMarshaller<UnrealSharp.SlateCore.ESlateColorStylingMode>.ToNative(IntPtr.Add(Buffer, ColorUseRule_Offset), 0, null, ColorUseRule);
        }
    }
}

public static class SlateColorMarshaler
{
    public static SlateColor FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SlateColor(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SlateColor obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SlateColor.NativeDataSize;
    }
}