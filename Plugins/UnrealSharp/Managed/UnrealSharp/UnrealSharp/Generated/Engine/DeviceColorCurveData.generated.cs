using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DeviceColorCurveData
{
    // BoolProperty /Script/Engine.DeviceColorCurveData:bEnable
    static readonly int bEnable_Offset;
    public bool Enable;
    
    // BoolProperty /Script/Engine.DeviceColorCurveData:bResetAfterCompletion
    static readonly int bResetAfterCompletion_Offset;
    public bool ResetAfterCompletion;
    
    // ObjectProperty /Script/Engine.DeviceColorCurveData:DeviceColorCurve
    static readonly int DeviceColorCurve_Offset;
    public UnrealSharp.Engine.CurveLinearColor DeviceColorCurve;
    
    
    public static readonly int NativeDataSize;
    static DeviceColorCurveData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DeviceColorCurveData");
        
        bEnable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnable");
        bResetAfterCompletion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bResetAfterCompletion");
        DeviceColorCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeviceColorCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DeviceColorCurveData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnable_Offset), 0, null);
            ResetAfterCompletion = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bResetAfterCompletion_Offset), 0, null);
            DeviceColorCurve = ObjectMarshaller<UnrealSharp.Engine.CurveLinearColor>.FromNative(IntPtr.Add(InNativeStruct, DeviceColorCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnable_Offset), 0, null, Enable);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bResetAfterCompletion_Offset), 0, null, ResetAfterCompletion);
            ObjectMarshaller<UnrealSharp.Engine.CurveLinearColor>.ToNative(IntPtr.Add(Buffer, DeviceColorCurve_Offset), 0, null, DeviceColorCurve);
        }
    }
}

public static class DeviceColorCurveDataMarshaler
{
    public static DeviceColorCurveData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DeviceColorCurveData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DeviceColorCurveData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DeviceColorCurveData.NativeDataSize;
    }
}