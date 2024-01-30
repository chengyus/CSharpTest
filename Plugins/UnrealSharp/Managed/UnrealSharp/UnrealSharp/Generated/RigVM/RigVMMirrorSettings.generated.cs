using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMMirrorSettings
{
    // ByteProperty /Script/RigVM.RigVMMirrorSettings:MirrorAxis
    static readonly int MirrorAxis_Offset;
    public UnrealSharp.CoreUObject.EAxis MirrorAxis;
    
    // ByteProperty /Script/RigVM.RigVMMirrorSettings:AxisToFlip
    static readonly int AxisToFlip_Offset;
    public UnrealSharp.CoreUObject.EAxis AxisToFlip;
    
    
    public static readonly int NativeDataSize;
    static RigVMMirrorSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMMirrorSettings");
        
        MirrorAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirrorAxis");
        AxisToFlip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AxisToFlip");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMMirrorSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MirrorAxis = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, MirrorAxis_Offset), 0, null);
            AxisToFlip = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, AxisToFlip_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, MirrorAxis_Offset), 0, null, MirrorAxis);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, AxisToFlip_Offset), 0, null, AxisToFlip);
        }
    }
}

public static class RigVMMirrorSettingsMarshaler
{
    public static RigVMMirrorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMMirrorSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMMirrorSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMMirrorSettings.NativeDataSize;
    }
}