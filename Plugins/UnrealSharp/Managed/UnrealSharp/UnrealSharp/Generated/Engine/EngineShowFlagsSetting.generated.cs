using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct EngineShowFlagsSetting
{
    // BoolProperty /Script/Engine.EngineShowFlagsSetting:Enabled
    static readonly int Enabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static EngineShowFlagsSetting()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EngineShowFlagsSetting");
        
        Enabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Enabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EngineShowFlagsSetting(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Enabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Enabled_Offset), 0, null, Enabled);
        }
    }
}

public static class EngineShowFlagsSettingMarshaler
{
    public static EngineShowFlagsSetting FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EngineShowFlagsSetting(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EngineShowFlagsSetting obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EngineShowFlagsSetting.NativeDataSize;
    }
}