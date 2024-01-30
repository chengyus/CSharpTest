using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DeviceColorData
{
    // BoolProperty /Script/Engine.DeviceColorData:bEnable
    static readonly int bEnable_Offset;
    public bool Enable;
    
    // BoolProperty /Script/Engine.DeviceColorData:bResetAfterCompletion
    static readonly int bResetAfterCompletion_Offset;
    public bool ResetAfterCompletion;
    
    // StructProperty /Script/Engine.DeviceColorData:LightColor
    static readonly int LightColor_Offset;
    public UnrealSharp.CoreUObject.Color LightColor;
    
    
    public static readonly int NativeDataSize;
    static DeviceColorData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DeviceColorData");
        
        bEnable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnable");
        bResetAfterCompletion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bResetAfterCompletion");
        LightColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LightColor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DeviceColorData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnable_Offset), 0, null);
            ResetAfterCompletion = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bResetAfterCompletion_Offset), 0, null);
            LightColor = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, LightColor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnable_Offset), 0, null, Enable);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bResetAfterCompletion_Offset), 0, null, ResetAfterCompletion);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, LightColor_Offset), 0, null, LightColor);
        }
    }
}

public static class DeviceColorDataMarshaler
{
    public static DeviceColorData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DeviceColorData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DeviceColorData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DeviceColorData.NativeDataSize;
    }
}