using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UStruct]
public partial struct RigSpacePickerBakeSettings
{
    // StructProperty /Script/ControlRigEditor.RigSpacePickerBakeSettings:TargetSpace
    static readonly int TargetSpace_Offset;
    public UnrealSharp.ControlRig.RigElementKey TargetSpace;
    
    // StructProperty /Script/ControlRigEditor.RigSpacePickerBakeSettings:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.MovieSceneTools.BakingAnimationKeySettings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigSpacePickerBakeSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigSpacePickerBakeSettings");
        
        TargetSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetSpace");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigSpacePickerBakeSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetSpace = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, TargetSpace_Offset), 0, null);
            Settings = UnrealSharp.MovieSceneTools.BakingAnimationKeySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, TargetSpace_Offset), 0, null, TargetSpace);
            UnrealSharp.MovieSceneTools.BakingAnimationKeySettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigSpacePickerBakeSettingsMarshaler
{
    public static RigSpacePickerBakeSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigSpacePickerBakeSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigSpacePickerBakeSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigSpacePickerBakeSettings.NativeDataSize;
    }
}