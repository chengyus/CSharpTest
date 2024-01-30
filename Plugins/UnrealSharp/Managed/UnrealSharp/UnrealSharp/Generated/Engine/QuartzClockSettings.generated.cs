using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct QuartzClockSettings
{
    // StructProperty /Script/Engine.QuartzClockSettings:TimeSignature
    static readonly int TimeSignature_Offset;
    public UnrealSharp.Engine.QuartzTimeSignature TimeSignature;
    
    // BoolProperty /Script/Engine.QuartzClockSettings:bIgnoreLevelChange
    static readonly int bIgnoreLevelChange_Offset;
    public bool IgnoreLevelChange;
    
    
    public static readonly int NativeDataSize;
    static QuartzClockSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("QuartzClockSettings");
        
        TimeSignature_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeSignature");
        bIgnoreLevelChange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreLevelChange");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public QuartzClockSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            TimeSignature = UnrealSharp.Engine.QuartzTimeSignatureMarshaler.FromNative(IntPtr.Add(InNativeStruct, TimeSignature_Offset), 0, null);
            IgnoreLevelChange = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIgnoreLevelChange_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.QuartzTimeSignatureMarshaler.ToNative(IntPtr.Add(Buffer, TimeSignature_Offset), 0, null, TimeSignature);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIgnoreLevelChange_Offset), 0, null, IgnoreLevelChange);
        }
    }
}

public static class QuartzClockSettingsMarshaler
{
    public static QuartzClockSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new QuartzClockSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, QuartzClockSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return QuartzClockSettings.NativeDataSize;
    }
}