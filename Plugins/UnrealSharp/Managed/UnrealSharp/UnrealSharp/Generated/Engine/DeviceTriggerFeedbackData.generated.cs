using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DeviceTriggerFeedbackData
{
    // ObjectProperty /Script/Engine.DeviceTriggerFeedbackData:FeedbackPositionCurve
    static readonly int FeedbackPositionCurve_Offset;
    public UnrealSharp.Engine.CurveFloat FeedbackPositionCurve;
    
    // ObjectProperty /Script/Engine.DeviceTriggerFeedbackData:FeedbackStrenghCurve
    static readonly int FeedbackStrenghCurve_Offset;
    public UnrealSharp.Engine.CurveFloat FeedbackStrenghCurve;
    
    
    public static readonly int NativeDataSize;
    static DeviceTriggerFeedbackData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DeviceTriggerFeedbackData");
        
        FeedbackPositionCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FeedbackPositionCurve");
        FeedbackStrenghCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FeedbackStrenghCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DeviceTriggerFeedbackData(IntPtr InNativeStruct)
    {
        unsafe
        {
            FeedbackPositionCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, FeedbackPositionCurve_Offset), 0, null);
            FeedbackStrenghCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, FeedbackStrenghCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, FeedbackPositionCurve_Offset), 0, null, FeedbackPositionCurve);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, FeedbackStrenghCurve_Offset), 0, null, FeedbackStrenghCurve);
        }
    }
}

public static class DeviceTriggerFeedbackDataMarshaler
{
    public static DeviceTriggerFeedbackData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DeviceTriggerFeedbackData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DeviceTriggerFeedbackData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DeviceTriggerFeedbackData.NativeDataSize;
    }
}