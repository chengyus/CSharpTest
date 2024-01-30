using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct PlatformInputDeviceState
{
    // StructProperty /Script/CoreUObject.PlatformInputDeviceState:OwningPlatformUser
    static readonly int OwningPlatformUser_Offset;
    public UnrealSharp.CoreUObject.PlatformUserId OwningPlatformUser;
    
    // EnumProperty /Script/CoreUObject.PlatformInputDeviceState:ConnectionState
    static readonly int ConnectionState_Offset;
    public UnrealSharp.CoreUObject.EInputDeviceConnectionState ConnectionState;
    
    
    public static readonly int NativeDataSize;
    static PlatformInputDeviceState()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PlatformInputDeviceState");
        
        OwningPlatformUser_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OwningPlatformUser");
        ConnectionState_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConnectionState");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PlatformInputDeviceState(IntPtr InNativeStruct)
    {
        unsafe
        {
            OwningPlatformUser = UnrealSharp.CoreUObject.PlatformUserIdMarshaler.FromNative(IntPtr.Add(InNativeStruct, OwningPlatformUser_Offset), 0, null);
            ConnectionState = BlittableMarshaller<UnrealSharp.CoreUObject.EInputDeviceConnectionState>.FromNative(IntPtr.Add(InNativeStruct, ConnectionState_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.PlatformUserIdMarshaler.ToNative(IntPtr.Add(Buffer, OwningPlatformUser_Offset), 0, null, OwningPlatformUser);
            BlittableMarshaller<UnrealSharp.CoreUObject.EInputDeviceConnectionState>.ToNative(IntPtr.Add(Buffer, ConnectionState_Offset), 0, null, ConnectionState);
        }
    }
}

public static class PlatformInputDeviceStateMarshaler
{
    public static PlatformInputDeviceState FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PlatformInputDeviceState(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PlatformInputDeviceState obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PlatformInputDeviceState.NativeDataSize;
    }
}