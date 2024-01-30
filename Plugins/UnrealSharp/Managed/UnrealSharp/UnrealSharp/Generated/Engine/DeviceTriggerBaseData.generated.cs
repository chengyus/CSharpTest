using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DeviceTriggerBaseData
{
    // EnumProperty /Script/Engine.DeviceTriggerBaseData:AffectedTriggers
    static readonly int AffectedTriggers_Offset;
    public UnrealSharp.CoreUObject.EInputDeviceTriggerMask AffectedTriggers;
    
    // BoolProperty /Script/Engine.DeviceTriggerBaseData:bResetUponCompletion
    static readonly int bResetUponCompletion_Offset;
    public bool ResetUponCompletion;
    
    
    public static readonly int NativeDataSize;
    static DeviceTriggerBaseData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DeviceTriggerBaseData");
        
        AffectedTriggers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AffectedTriggers");
        bResetUponCompletion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bResetUponCompletion");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DeviceTriggerBaseData(IntPtr InNativeStruct)
    {
        unsafe
        {
            AffectedTriggers = BlittableMarshaller<UnrealSharp.CoreUObject.EInputDeviceTriggerMask>.FromNative(IntPtr.Add(InNativeStruct, AffectedTriggers_Offset), 0, null);
            ResetUponCompletion = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bResetUponCompletion_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.EInputDeviceTriggerMask>.ToNative(IntPtr.Add(Buffer, AffectedTriggers_Offset), 0, null, AffectedTriggers);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bResetUponCompletion_Offset), 0, null, ResetUponCompletion);
        }
    }
}

public static class DeviceTriggerBaseDataMarshaler
{
    public static DeviceTriggerBaseData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DeviceTriggerBaseData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DeviceTriggerBaseData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DeviceTriggerBaseData.NativeDataSize;
    }
}