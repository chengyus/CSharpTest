using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct LensSettings
{
    // StructProperty /Script/Engine.LensSettings:Bloom
    static readonly int Bloom_Offset;
    public UnrealSharp.Engine.LensBloomSettings Bloom;
    
    // StructProperty /Script/Engine.LensSettings:Imperfections
    static readonly int Imperfections_Offset;
    public UnrealSharp.Engine.LensImperfectionSettings Imperfections;
    
    // FloatProperty /Script/Engine.LensSettings:ChromaticAberration
    static readonly int ChromaticAberration_Offset;
    public float ChromaticAberration;
    
    
    public static readonly int NativeDataSize;
    static LensSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LensSettings");
        
        Bloom_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom");
        Imperfections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Imperfections");
        ChromaticAberration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChromaticAberration");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LensSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bloom = UnrealSharp.Engine.LensBloomSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bloom_Offset), 0, null);
            Imperfections = UnrealSharp.Engine.LensImperfectionSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Imperfections_Offset), 0, null);
            ChromaticAberration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChromaticAberration_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.LensBloomSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Bloom_Offset), 0, null, Bloom);
            UnrealSharp.Engine.LensImperfectionSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Imperfections_Offset), 0, null, Imperfections);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChromaticAberration_Offset), 0, null, ChromaticAberration);
        }
    }
}

public static class LensSettingsMarshaler
{
    public static LensSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LensSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LensSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LensSettings.NativeDataSize;
    }
}