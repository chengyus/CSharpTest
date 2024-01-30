using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MontageBlendSettings
{
    // ObjectProperty /Script/Engine.MontageBlendSettings:BlendProfile
    static readonly int BlendProfile_Offset;
    public UnrealSharp.Engine.BlendProfile BlendProfile;
    
    // StructProperty /Script/Engine.MontageBlendSettings:Blend
    static readonly int Blend_Offset;
    public UnrealSharp.Engine.AlphaBlendArgs Blend;
    
    // EnumProperty /Script/Engine.MontageBlendSettings:BlendMode
    static readonly int BlendMode_Offset;
    public UnrealSharp.Engine.EMontageBlendMode BlendMode;
    
    
    public static readonly int NativeDataSize;
    static MontageBlendSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MontageBlendSettings");
        
        BlendProfile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendProfile");
        Blend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Blend");
        BlendMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MontageBlendSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlendProfile = ObjectMarshaller<UnrealSharp.Engine.BlendProfile>.FromNative(IntPtr.Add(InNativeStruct, BlendProfile_Offset), 0, null);
            Blend = UnrealSharp.Engine.AlphaBlendArgsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Blend_Offset), 0, null);
            BlendMode = BlittableMarshaller<UnrealSharp.Engine.EMontageBlendMode>.FromNative(IntPtr.Add(InNativeStruct, BlendMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.BlendProfile>.ToNative(IntPtr.Add(Buffer, BlendProfile_Offset), 0, null, BlendProfile);
            UnrealSharp.Engine.AlphaBlendArgsMarshaler.ToNative(IntPtr.Add(Buffer, Blend_Offset), 0, null, Blend);
            BlittableMarshaller<UnrealSharp.Engine.EMontageBlendMode>.ToNative(IntPtr.Add(Buffer, BlendMode_Offset), 0, null, BlendMode);
        }
    }
}

public static class MontageBlendSettingsMarshaler
{
    public static MontageBlendSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MontageBlendSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MontageBlendSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MontageBlendSettings.NativeDataSize;
    }
}