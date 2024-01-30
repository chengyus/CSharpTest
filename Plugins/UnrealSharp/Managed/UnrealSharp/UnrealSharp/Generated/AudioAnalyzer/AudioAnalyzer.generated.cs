// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioAnalyzer;

[UClass]
abstract public partial class AudioAnalyzer : UnrealSharp.CoreUObject.Object
{
    
    static AudioAnalyzer()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AudioAnalyzer");
        
        
        StopAnalyzing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StopAnalyzing");
        StopAnalyzing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StopAnalyzing_NativeFunction);
        StopAnalyzing_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StopAnalyzing_NativeFunction, "WorldContextObject");
        StartAnalyzing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartAnalyzing");
        StartAnalyzing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StartAnalyzing_NativeFunction);
        StartAnalyzing_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartAnalyzing_NativeFunction, "WorldContextObject");
        StartAnalyzing_AudioBusToAnalyze_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartAnalyzing_NativeFunction, "AudioBusToAnalyze");
        
        
    }
    
    protected AudioAnalyzer(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/AudioAnalyzer.AudioAnalyzer:StopAnalyzing
    static readonly IntPtr StopAnalyzing_NativeFunction;
    static readonly int StopAnalyzing_ParamsSize;
    static readonly int StopAnalyzing_WorldContextObject_Offset;
    
    public void StopAnalyzing(UnrealSharp.CoreUObject.Object worldContextObject = default(UnrealSharp.CoreUObject.Object))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StopAnalyzing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, StopAnalyzing_WorldContextObject_Offset), 0, null, worldContextObject);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StopAnalyzing_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AudioAnalyzer.AudioAnalyzer:StartAnalyzing
    static readonly IntPtr StartAnalyzing_NativeFunction;
    static readonly int StartAnalyzing_ParamsSize;
    static readonly int StartAnalyzing_WorldContextObject_Offset;
    static readonly int StartAnalyzing_AudioBusToAnalyze_Offset;
    
    public void StartAnalyzing(UnrealSharp.CoreUObject.Object worldContextObject, UnrealSharp.Engine.AudioBus audioBusToAnalyze)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StartAnalyzing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, StartAnalyzing_WorldContextObject_Offset), 0, null, worldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.AudioBus>.ToNative(IntPtr.Add(ParamsBuffer, StartAnalyzing_AudioBusToAnalyze_Offset), 0, null, audioBusToAnalyze);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StartAnalyzing_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}