using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioExtensions;

[UStruct]
public partial struct AudioParameter
{
    // NameProperty /Script/AudioExtensions.AudioParameter:ParamName
    static readonly int ParamName_Offset;
    public Name ParamName;
    
    // FloatProperty /Script/AudioExtensions.AudioParameter:FloatParam
    static readonly int FloatParam_Offset;
    public float FloatParam;
    
    // BoolProperty /Script/AudioExtensions.AudioParameter:BoolParam
    static readonly int BoolParam_Offset;
    public bool BoolParam;
    
    // IntProperty /Script/AudioExtensions.AudioParameter:IntParam
    static readonly int IntParam_Offset;
    public int IntParam;
    
    // ObjectProperty /Script/AudioExtensions.AudioParameter:ObjectParam
    static readonly int ObjectParam_Offset;
    public UnrealSharp.CoreUObject.Object ObjectParam;
    
    // EnumProperty /Script/AudioExtensions.AudioParameter:ParamType
    static readonly int ParamType_Offset;
    public UnrealSharp.AudioExtensions.EAudioParameterType ParamType;
    
    
    public static readonly int NativeDataSize;
    static AudioParameter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioParameter");
        
        ParamName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamName");
        FloatParam_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FloatParam");
        BoolParam_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoolParam");
        IntParam_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IntParam");
        ObjectParam_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ObjectParam");
        ParamType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioParameter(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParamName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParamName_Offset), 0, null);
            FloatParam = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FloatParam_Offset), 0, null);
            BoolParam = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, BoolParam_Offset), 0, null);
            IntParam = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, IntParam_Offset), 0, null);
            ObjectParam = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, ObjectParam_Offset), 0, null);
            ParamType = BlittableMarshaller<UnrealSharp.AudioExtensions.EAudioParameterType>.FromNative(IntPtr.Add(InNativeStruct, ParamType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ParamName_Offset), 0, null, ParamName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FloatParam_Offset), 0, null, FloatParam);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, BoolParam_Offset), 0, null, BoolParam);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, IntParam_Offset), 0, null, IntParam);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, ObjectParam_Offset), 0, null, ObjectParam);
            BlittableMarshaller<UnrealSharp.AudioExtensions.EAudioParameterType>.ToNative(IntPtr.Add(Buffer, ParamType_Offset), 0, null, ParamType);
        }
    }
}

public static class AudioParameterMarshaler
{
    public static AudioParameter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioParameter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioParameter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioParameter.NativeDataSize;
    }
}