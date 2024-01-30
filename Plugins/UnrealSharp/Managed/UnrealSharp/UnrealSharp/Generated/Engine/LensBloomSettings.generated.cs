using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct LensBloomSettings
{
    // StructProperty /Script/Engine.LensBloomSettings:GaussianSum
    static readonly int GaussianSum_Offset;
    public UnrealSharp.Engine.GaussianSumBloomSettings GaussianSum;
    
    // StructProperty /Script/Engine.LensBloomSettings:Convolution
    static readonly int Convolution_Offset;
    public UnrealSharp.Engine.ConvolutionBloomSettings Convolution;
    
    // ByteProperty /Script/Engine.LensBloomSettings:Method
    static readonly int Method_Offset;
    public UnrealSharp.Engine.EBloomMethod Method;
    
    
    public static readonly int NativeDataSize;
    static LensBloomSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LensBloomSettings");
        
        GaussianSum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GaussianSum");
        Convolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Convolution");
        Method_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Method");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LensBloomSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            GaussianSum = BlittableMarshaller<UnrealSharp.Engine.GaussianSumBloomSettings>.FromNative(IntPtr.Add(InNativeStruct, GaussianSum_Offset), 0, null);
            Convolution = UnrealSharp.Engine.ConvolutionBloomSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Convolution_Offset), 0, null);
            Method = BlittableMarshaller<UnrealSharp.Engine.EBloomMethod>.FromNative(IntPtr.Add(InNativeStruct, Method_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.GaussianSumBloomSettings>.ToNative(IntPtr.Add(Buffer, GaussianSum_Offset), 0, null, GaussianSum);
            UnrealSharp.Engine.ConvolutionBloomSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Convolution_Offset), 0, null, Convolution);
            BlittableMarshaller<UnrealSharp.Engine.EBloomMethod>.ToNative(IntPtr.Add(Buffer, Method_Offset), 0, null, Method);
        }
    }
}

public static class LensBloomSettingsMarshaler
{
    public static LensBloomSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LensBloomSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LensBloomSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LensBloomSettings.NativeDataSize;
    }
}