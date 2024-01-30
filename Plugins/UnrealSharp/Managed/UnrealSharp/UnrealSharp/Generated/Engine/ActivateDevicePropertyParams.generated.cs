using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ActivateDevicePropertyParams
{
    // StructProperty /Script/Engine.ActivateDevicePropertyParams:UserId
    static readonly int UserId_Offset;
    public UnrealSharp.CoreUObject.PlatformUserId UserId;
    
    // StructProperty /Script/Engine.ActivateDevicePropertyParams:DeviceId
    static readonly int DeviceId_Offset;
    public UnrealSharp.CoreUObject.InputDeviceId DeviceId;
    
    // BoolProperty /Script/Engine.ActivateDevicePropertyParams:bLooping
    static readonly int bLooping_Offset;
    static readonly IntPtr bLooping_NativeProperty;
    public bool Looping;
    
    // BoolProperty /Script/Engine.ActivateDevicePropertyParams:bIgnoreTimeDilation
    static readonly int bIgnoreTimeDilation_Offset;
    static readonly IntPtr bIgnoreTimeDilation_NativeProperty;
    public bool IgnoreTimeDilation;
    
    // BoolProperty /Script/Engine.ActivateDevicePropertyParams:bPlayWhilePaused
    static readonly int bPlayWhilePaused_Offset;
    static readonly IntPtr bPlayWhilePaused_NativeProperty;
    public bool PlayWhilePaused;
    
    
    public static readonly int NativeDataSize;
    static ActivateDevicePropertyParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ActivateDevicePropertyParams");
        
        UserId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserId");
        DeviceId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeviceId");
        bLooping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLooping");
        bLooping_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLooping");
        bIgnoreTimeDilation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreTimeDilation");
        bIgnoreTimeDilation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIgnoreTimeDilation");
        bPlayWhilePaused_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPlayWhilePaused");
        bPlayWhilePaused_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPlayWhilePaused");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ActivateDevicePropertyParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            UserId = UnrealSharp.CoreUObject.PlatformUserIdMarshaler.FromNative(IntPtr.Add(InNativeStruct, UserId_Offset), 0, null);
            DeviceId = UnrealSharp.CoreUObject.InputDeviceIdMarshaler.FromNative(IntPtr.Add(InNativeStruct, DeviceId_Offset), 0, null);
            Looping = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bLooping_NativeProperty, bLooping_Offset);
            IgnoreTimeDilation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIgnoreTimeDilation_NativeProperty, bIgnoreTimeDilation_Offset);
            PlayWhilePaused = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bPlayWhilePaused_NativeProperty, bPlayWhilePaused_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.PlatformUserIdMarshaler.ToNative(IntPtr.Add(Buffer, UserId_Offset), 0, null, UserId);
            UnrealSharp.CoreUObject.InputDeviceIdMarshaler.ToNative(IntPtr.Add(Buffer, DeviceId_Offset), 0, null, DeviceId);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bLooping_NativeProperty, bLooping_Offset, Looping);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIgnoreTimeDilation_NativeProperty, bIgnoreTimeDilation_Offset, IgnoreTimeDilation);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bPlayWhilePaused_NativeProperty, bPlayWhilePaused_Offset, PlayWhilePaused);
        }
    }
}

public static class ActivateDevicePropertyParamsMarshaler
{
    public static ActivateDevicePropertyParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ActivateDevicePropertyParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ActivateDevicePropertyParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ActivateDevicePropertyParams.NativeDataSize;
    }
}