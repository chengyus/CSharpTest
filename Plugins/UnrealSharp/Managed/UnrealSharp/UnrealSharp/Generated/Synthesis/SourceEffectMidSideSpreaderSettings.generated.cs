using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectMidSideSpreaderSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectMidSideSpreaderSettings:SpreadAmount
    static readonly int SpreadAmount_Offset;
    public float SpreadAmount;
    
    // EnumProperty /Script/Synthesis.SourceEffectMidSideSpreaderSettings:InputMode
    static readonly int InputMode_Offset;
    public UnrealSharp.Synthesis.EStereoChannelMode InputMode;
    
    // EnumProperty /Script/Synthesis.SourceEffectMidSideSpreaderSettings:OutputMode
    static readonly int OutputMode_Offset;
    public UnrealSharp.Synthesis.EStereoChannelMode OutputMode;
    
    // BoolProperty /Script/Synthesis.SourceEffectMidSideSpreaderSettings:bEqualPower
    static readonly int bEqualPower_Offset;
    public bool EqualPower;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectMidSideSpreaderSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectMidSideSpreaderSettings");
        
        SpreadAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpreadAmount");
        InputMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputMode");
        OutputMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputMode");
        bEqualPower_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEqualPower");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectMidSideSpreaderSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpreadAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpreadAmount_Offset), 0, null);
            InputMode = BlittableMarshaller<UnrealSharp.Synthesis.EStereoChannelMode>.FromNative(IntPtr.Add(InNativeStruct, InputMode_Offset), 0, null);
            OutputMode = BlittableMarshaller<UnrealSharp.Synthesis.EStereoChannelMode>.FromNative(IntPtr.Add(InNativeStruct, OutputMode_Offset), 0, null);
            EqualPower = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEqualPower_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpreadAmount_Offset), 0, null, SpreadAmount);
            BlittableMarshaller<UnrealSharp.Synthesis.EStereoChannelMode>.ToNative(IntPtr.Add(Buffer, InputMode_Offset), 0, null, InputMode);
            BlittableMarshaller<UnrealSharp.Synthesis.EStereoChannelMode>.ToNative(IntPtr.Add(Buffer, OutputMode_Offset), 0, null, OutputMode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEqualPower_Offset), 0, null, EqualPower);
        }
    }
}

public static class SourceEffectMidSideSpreaderSettingsMarshaler
{
    public static SourceEffectMidSideSpreaderSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectMidSideSpreaderSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectMidSideSpreaderSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectMidSideSpreaderSettings.NativeDataSize;
    }
}