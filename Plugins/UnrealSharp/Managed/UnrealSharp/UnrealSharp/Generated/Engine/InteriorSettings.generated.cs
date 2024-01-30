using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct InteriorSettings
{
    // FloatProperty /Script/Engine.InteriorSettings:ExteriorVolume
    static readonly int ExteriorVolume_Offset;
    public float ExteriorVolume;
    
    // FloatProperty /Script/Engine.InteriorSettings:ExteriorTime
    static readonly int ExteriorTime_Offset;
    public float ExteriorTime;
    
    // FloatProperty /Script/Engine.InteriorSettings:ExteriorLPF
    static readonly int ExteriorLPF_Offset;
    public float ExteriorLPF;
    
    // FloatProperty /Script/Engine.InteriorSettings:ExteriorLPFTime
    static readonly int ExteriorLPFTime_Offset;
    public float ExteriorLPFTime;
    
    // FloatProperty /Script/Engine.InteriorSettings:InteriorVolume
    static readonly int InteriorVolume_Offset;
    public float InteriorVolume;
    
    // FloatProperty /Script/Engine.InteriorSettings:InteriorTime
    static readonly int InteriorTime_Offset;
    public float InteriorTime;
    
    // FloatProperty /Script/Engine.InteriorSettings:InteriorLPF
    static readonly int InteriorLPF_Offset;
    public float InteriorLPF;
    
    // FloatProperty /Script/Engine.InteriorSettings:InteriorLPFTime
    static readonly int InteriorLPFTime_Offset;
    public float InteriorLPFTime;
    
    
    public static readonly int NativeDataSize;
    static InteriorSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InteriorSettings");
        
        ExteriorVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExteriorVolume");
        ExteriorTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExteriorTime");
        ExteriorLPF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExteriorLPF");
        ExteriorLPFTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExteriorLPFTime");
        InteriorVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InteriorVolume");
        InteriorTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InteriorTime");
        InteriorLPF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InteriorLPF");
        InteriorLPFTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InteriorLPFTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InteriorSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExteriorVolume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExteriorVolume_Offset), 0, null);
            ExteriorTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExteriorTime_Offset), 0, null);
            ExteriorLPF = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExteriorLPF_Offset), 0, null);
            ExteriorLPFTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExteriorLPFTime_Offset), 0, null);
            InteriorVolume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InteriorVolume_Offset), 0, null);
            InteriorTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InteriorTime_Offset), 0, null);
            InteriorLPF = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InteriorLPF_Offset), 0, null);
            InteriorLPFTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InteriorLPFTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExteriorVolume_Offset), 0, null, ExteriorVolume);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExteriorTime_Offset), 0, null, ExteriorTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExteriorLPF_Offset), 0, null, ExteriorLPF);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExteriorLPFTime_Offset), 0, null, ExteriorLPFTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InteriorVolume_Offset), 0, null, InteriorVolume);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InteriorTime_Offset), 0, null, InteriorTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InteriorLPF_Offset), 0, null, InteriorLPF);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InteriorLPFTime_Offset), 0, null, InteriorLPFTime);
        }
    }
}

public static class InteriorSettingsMarshaler
{
    public static InteriorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InteriorSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InteriorSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InteriorSettings.NativeDataSize;
    }
}