using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ConvolutionBloomSettings
{
    // ObjectProperty /Script/Engine.ConvolutionBloomSettings:Texture
    static readonly int Texture_Offset;
    public UnrealSharp.Engine.Texture2D Texture;
    
    // FloatProperty /Script/Engine.ConvolutionBloomSettings:ScatterDispersion
    static readonly int ScatterDispersion_Offset;
    public float ScatterDispersion;
    
    // FloatProperty /Script/Engine.ConvolutionBloomSettings:Size
    static readonly int Size_Offset;
    public float Size;
    
    // StructProperty /Script/Engine.ConvolutionBloomSettings:CenterUV
    static readonly int CenterUV_Offset;
    public System.DoubleNumerics.Vector2 CenterUV;
    
    // FloatProperty /Script/Engine.ConvolutionBloomSettings:PreFilterMin
    static readonly int PreFilterMin_Offset;
    public float PreFilterMin;
    
    // FloatProperty /Script/Engine.ConvolutionBloomSettings:PreFilterMax
    static readonly int PreFilterMax_Offset;
    public float PreFilterMax;
    
    // FloatProperty /Script/Engine.ConvolutionBloomSettings:PreFilterMult
    static readonly int PreFilterMult_Offset;
    public float PreFilterMult;
    
    // FloatProperty /Script/Engine.ConvolutionBloomSettings:BufferScale
    static readonly int BufferScale_Offset;
    public float BufferScale;
    
    
    public static readonly int NativeDataSize;
    static ConvolutionBloomSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ConvolutionBloomSettings");
        
        Texture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Texture");
        ScatterDispersion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScatterDispersion");
        Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Size");
        CenterUV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CenterUV");
        PreFilterMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreFilterMin");
        PreFilterMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreFilterMax");
        PreFilterMult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreFilterMult");
        BufferScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BufferScale");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ConvolutionBloomSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Texture = ObjectMarshaller<UnrealSharp.Engine.Texture2D>.FromNative(IntPtr.Add(InNativeStruct, Texture_Offset), 0, null);
            ScatterDispersion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScatterDispersion_Offset), 0, null);
            Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Size_Offset), 0, null);
            CenterUV = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, CenterUV_Offset), 0, null);
            PreFilterMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PreFilterMin_Offset), 0, null);
            PreFilterMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PreFilterMax_Offset), 0, null);
            PreFilterMult = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PreFilterMult_Offset), 0, null);
            BufferScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BufferScale_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Texture2D>.ToNative(IntPtr.Add(Buffer, Texture_Offset), 0, null, Texture);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScatterDispersion_Offset), 0, null, ScatterDispersion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Size_Offset), 0, null, Size);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, CenterUV_Offset), 0, null, CenterUV);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PreFilterMin_Offset), 0, null, PreFilterMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PreFilterMax_Offset), 0, null, PreFilterMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PreFilterMult_Offset), 0, null, PreFilterMult);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BufferScale_Offset), 0, null, BufferScale);
        }
    }
}

public static class ConvolutionBloomSettingsMarshaler
{
    public static ConvolutionBloomSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ConvolutionBloomSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ConvolutionBloomSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ConvolutionBloomSettings.NativeDataSize;
    }
}