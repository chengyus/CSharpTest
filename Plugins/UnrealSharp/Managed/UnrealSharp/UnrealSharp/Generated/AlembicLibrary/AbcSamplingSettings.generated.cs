using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcSamplingSettings
{
    // EnumProperty /Script/AlembicLibrary.AbcSamplingSettings:SamplingType
    static readonly int SamplingType_Offset;
    public UnrealSharp.AlembicLibrary.EAlembicSamplingType SamplingType;
    
    // IntProperty /Script/AlembicLibrary.AbcSamplingSettings:FrameSteps
    static readonly int FrameSteps_Offset;
    public int FrameSteps;
    
    // FloatProperty /Script/AlembicLibrary.AbcSamplingSettings:TimeSteps
    static readonly int TimeSteps_Offset;
    public float TimeSteps;
    
    // IntProperty /Script/AlembicLibrary.AbcSamplingSettings:FrameStart
    static readonly int FrameStart_Offset;
    public int FrameStart;
    
    // IntProperty /Script/AlembicLibrary.AbcSamplingSettings:FrameEnd
    static readonly int FrameEnd_Offset;
    public int FrameEnd;
    
    // BoolProperty /Script/AlembicLibrary.AbcSamplingSettings:bSkipEmpty
    static readonly int bSkipEmpty_Offset;
    public bool SkipEmpty;
    
    
    public static readonly int NativeDataSize;
    static AbcSamplingSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcSamplingSettings");
        
        SamplingType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SamplingType");
        FrameSteps_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameSteps");
        TimeSteps_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeSteps");
        FrameStart_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameStart");
        FrameEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameEnd");
        bSkipEmpty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipEmpty");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcSamplingSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            SamplingType = BlittableMarshaller<UnrealSharp.AlembicLibrary.EAlembicSamplingType>.FromNative(IntPtr.Add(InNativeStruct, SamplingType_Offset), 0, null);
            FrameSteps = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FrameSteps_Offset), 0, null);
            TimeSteps = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TimeSteps_Offset), 0, null);
            FrameStart = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FrameStart_Offset), 0, null);
            FrameEnd = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FrameEnd_Offset), 0, null);
            SkipEmpty = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipEmpty_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AlembicLibrary.EAlembicSamplingType>.ToNative(IntPtr.Add(Buffer, SamplingType_Offset), 0, null, SamplingType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FrameSteps_Offset), 0, null, FrameSteps);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TimeSteps_Offset), 0, null, TimeSteps);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FrameStart_Offset), 0, null, FrameStart);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FrameEnd_Offset), 0, null, FrameEnd);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipEmpty_Offset), 0, null, SkipEmpty);
        }
    }
}

public static class AbcSamplingSettingsMarshaler
{
    public static AbcSamplingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcSamplingSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcSamplingSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcSamplingSettings.NativeDataSize;
    }
}