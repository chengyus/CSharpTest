// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioAnalyzer;

[UClass]
abstract public partial class AudioAnalyzerNRT : UnrealSharp.AudioAnalyzer.AudioAnalyzerAssetBase
{
    
    static AudioAnalyzerNRT()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AudioAnalyzerNRT");
        
        Sound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sound");
        DurationInSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DurationInSeconds");
        
        
        
    }
    
    protected AudioAnalyzerNRT(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/AudioAnalyzer.AudioAnalyzerNRT:Sound
    static readonly int Sound_Offset;
    
    public UnrealSharp.Engine.SoundWave Sound
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SoundWave>.FromNative(IntPtr.Add(NativeObject, Sound_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/AudioAnalyzer.AudioAnalyzerNRT:DurationInSeconds
    static readonly int DurationInSeconds_Offset;
    
    public float DurationInSeconds
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DurationInSeconds_Offset), 0, this);
        }
    }
    
    
}