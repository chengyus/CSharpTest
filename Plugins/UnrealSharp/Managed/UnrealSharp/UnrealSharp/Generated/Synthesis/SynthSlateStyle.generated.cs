using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SynthSlateStyle
{
    // EnumProperty /Script/Synthesis.SynthSlateStyle:SizeType
    static readonly int SizeType_Offset;
    public UnrealSharp.Synthesis.ESynthSlateSizeType SizeType;
    
    // EnumProperty /Script/Synthesis.SynthSlateStyle:ColorStyle
    static readonly int ColorStyle_Offset;
    public UnrealSharp.Synthesis.ESynthSlateColorStyle ColorStyle;
    
    
    public static readonly int NativeDataSize;
    static SynthSlateStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SynthSlateStyle");
        
        SizeType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SizeType");
        ColorStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorStyle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SynthSlateStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            SizeType = BlittableMarshaller<UnrealSharp.Synthesis.ESynthSlateSizeType>.FromNative(IntPtr.Add(InNativeStruct, SizeType_Offset), 0, null);
            ColorStyle = BlittableMarshaller<UnrealSharp.Synthesis.ESynthSlateColorStyle>.FromNative(IntPtr.Add(InNativeStruct, ColorStyle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthSlateSizeType>.ToNative(IntPtr.Add(Buffer, SizeType_Offset), 0, null, SizeType);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthSlateColorStyle>.ToNative(IntPtr.Add(Buffer, ColorStyle_Offset), 0, null, ColorStyle);
        }
    }
}

public static class SynthSlateStyleMarshaler
{
    public static SynthSlateStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SynthSlateStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SynthSlateStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SynthSlateStyle.NativeDataSize;
    }
}