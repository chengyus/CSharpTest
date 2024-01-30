using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DeviceTriggerTriggerVibrationData
{
    // ObjectProperty /Script/Engine.DeviceTriggerTriggerVibrationData:TriggerPositionCurve
    static readonly int TriggerPositionCurve_Offset;
    public UnrealSharp.Engine.CurveFloat TriggerPositionCurve;
    
    // ObjectProperty /Script/Engine.DeviceTriggerTriggerVibrationData:VibrationFrequencyCurve
    static readonly int VibrationFrequencyCurve_Offset;
    public UnrealSharp.Engine.CurveFloat VibrationFrequencyCurve;
    
    // ObjectProperty /Script/Engine.DeviceTriggerTriggerVibrationData:VibrationAmplitudeCurve
    static readonly int VibrationAmplitudeCurve_Offset;
    public UnrealSharp.Engine.CurveFloat VibrationAmplitudeCurve;
    
    
    public static readonly int NativeDataSize;
    static DeviceTriggerTriggerVibrationData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DeviceTriggerTriggerVibrationData");
        
        TriggerPositionCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TriggerPositionCurve");
        VibrationFrequencyCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VibrationFrequencyCurve");
        VibrationAmplitudeCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VibrationAmplitudeCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DeviceTriggerTriggerVibrationData(IntPtr InNativeStruct)
    {
        unsafe
        {
            TriggerPositionCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, TriggerPositionCurve_Offset), 0, null);
            VibrationFrequencyCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, VibrationFrequencyCurve_Offset), 0, null);
            VibrationAmplitudeCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, VibrationAmplitudeCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, TriggerPositionCurve_Offset), 0, null, TriggerPositionCurve);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, VibrationFrequencyCurve_Offset), 0, null, VibrationFrequencyCurve);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, VibrationAmplitudeCurve_Offset), 0, null, VibrationAmplitudeCurve);
        }
    }
}

public static class DeviceTriggerTriggerVibrationDataMarshaler
{
    public static DeviceTriggerTriggerVibrationData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DeviceTriggerTriggerVibrationData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DeviceTriggerTriggerVibrationData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DeviceTriggerTriggerVibrationData.NativeDataSize;
    }
}