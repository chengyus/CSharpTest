using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct LightingChannels
{
    // BoolProperty /Script/Engine.LightingChannels:bChannel0
    static readonly int bChannel0_Offset;
    static readonly IntPtr bChannel0_NativeProperty;
    public bool Channel0;
    
    // BoolProperty /Script/Engine.LightingChannels:bChannel1
    static readonly int bChannel1_Offset;
    static readonly IntPtr bChannel1_NativeProperty;
    public bool Channel1;
    
    // BoolProperty /Script/Engine.LightingChannels:bChannel2
    static readonly int bChannel2_Offset;
    static readonly IntPtr bChannel2_NativeProperty;
    public bool Channel2;
    
    
    public static readonly int NativeDataSize;
    static LightingChannels()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LightingChannels");
        
        bChannel0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChannel0");
        bChannel0_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bChannel0");
        bChannel1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChannel1");
        bChannel1_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bChannel1");
        bChannel2_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChannel2");
        bChannel2_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bChannel2");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LightingChannels(IntPtr InNativeStruct)
    {
        unsafe
        {
            Channel0 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bChannel0_NativeProperty, bChannel0_Offset);
            Channel1 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bChannel1_NativeProperty, bChannel1_Offset);
            Channel2 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bChannel2_NativeProperty, bChannel2_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bChannel0_NativeProperty, bChannel0_Offset, Channel0);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bChannel1_NativeProperty, bChannel1_Offset, Channel1);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bChannel2_NativeProperty, bChannel2_Offset, Channel2);
        }
    }
}

public static class LightingChannelsMarshaler
{
    public static LightingChannels FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LightingChannels(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LightingChannels obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LightingChannels.NativeDataSize;
    }
}