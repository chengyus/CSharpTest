using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigRigidBodyElement
{
    // StructProperty /Script/ControlRig.RigRigidBodyElement:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigRigidBodySettings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigRigidBodyElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigRigidBodyElement");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigRigidBodyElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            Settings = BlittableMarshaller<UnrealSharp.ControlRig.RigRigidBodySettings>.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.RigRigidBodySettings>.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigRigidBodyElementMarshaler
{
    public static RigRigidBodyElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigRigidBodyElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigRigidBodyElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigRigidBodyElement.NativeDataSize;
    }
}