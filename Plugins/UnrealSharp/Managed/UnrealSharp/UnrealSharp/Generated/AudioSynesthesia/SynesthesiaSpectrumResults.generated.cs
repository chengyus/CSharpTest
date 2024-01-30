using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UStruct]
public partial struct SynesthesiaSpectrumResults
{
    // FloatProperty /Script/AudioSynesthesia.SynesthesiaSpectrumResults:TimeSeconds
    static readonly int TimeSeconds_Offset;
    public float TimeSeconds;
    
    
    public static readonly int NativeDataSize;
    static SynesthesiaSpectrumResults()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SynesthesiaSpectrumResults");
        
        TimeSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeSeconds");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SynesthesiaSpectrumResults(IntPtr InNativeStruct)
    {
        unsafe
        {
            TimeSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TimeSeconds_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TimeSeconds_Offset), 0, null, TimeSeconds);
        }
    }
}

public static class SynesthesiaSpectrumResultsMarshaler
{
    public static SynesthesiaSpectrumResults FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SynesthesiaSpectrumResults(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SynesthesiaSpectrumResults obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SynesthesiaSpectrumResults.NativeDataSize;
    }
}