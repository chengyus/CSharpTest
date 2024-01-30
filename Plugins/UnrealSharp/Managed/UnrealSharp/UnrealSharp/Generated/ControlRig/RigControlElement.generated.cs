using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigControlElement
{
    // StructProperty /Script/ControlRig.RigControlElement:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigControlSettings Settings;
    
    // StructProperty /Script/ControlRig.RigControlElement:Offset
    static readonly int Offset_Offset;
    public UnrealSharp.ControlRig.RigCurrentAndInitialTransform Offset;
    
    // StructProperty /Script/ControlRig.RigControlElement:Shape
    static readonly int Shape_Offset;
    public UnrealSharp.ControlRig.RigCurrentAndInitialTransform Shape;
    
    // StructProperty /Script/ControlRig.RigControlElement:PreferredEulerAngles
    static readonly int PreferredEulerAngles_Offset;
    public UnrealSharp.ControlRig.RigPreferredEulerAngles PreferredEulerAngles;
    
    
    public static readonly int NativeDataSize;
    static RigControlElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigControlElement");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        Offset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Offset");
        Shape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Shape");
        PreferredEulerAngles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreferredEulerAngles");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigControlElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            Settings = UnrealSharp.ControlRig.RigControlSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
            Offset = UnrealSharp.ControlRig.RigCurrentAndInitialTransformMarshaler.FromNative(IntPtr.Add(InNativeStruct, Offset_Offset), 0, null);
            Shape = UnrealSharp.ControlRig.RigCurrentAndInitialTransformMarshaler.FromNative(IntPtr.Add(InNativeStruct, Shape_Offset), 0, null);
            PreferredEulerAngles = UnrealSharp.ControlRig.RigPreferredEulerAnglesMarshaler.FromNative(IntPtr.Add(InNativeStruct, PreferredEulerAngles_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigControlSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
            UnrealSharp.ControlRig.RigCurrentAndInitialTransformMarshaler.ToNative(IntPtr.Add(Buffer, Offset_Offset), 0, null, Offset);
            UnrealSharp.ControlRig.RigCurrentAndInitialTransformMarshaler.ToNative(IntPtr.Add(Buffer, Shape_Offset), 0, null, Shape);
            UnrealSharp.ControlRig.RigPreferredEulerAnglesMarshaler.ToNative(IntPtr.Add(Buffer, PreferredEulerAngles_Offset), 0, null, PreferredEulerAngles);
        }
    }
}

public static class RigControlElementMarshaler
{
    public static RigControlElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigControlElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigControlElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigControlElement.NativeDataSize;
    }
}