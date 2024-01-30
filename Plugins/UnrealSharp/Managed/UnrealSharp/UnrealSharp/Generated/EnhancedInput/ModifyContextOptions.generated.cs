using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct ModifyContextOptions
{
    // BoolProperty /Script/EnhancedInput.ModifyContextOptions:bIgnoreAllPressedKeysUntilRelease
    static readonly int bIgnoreAllPressedKeysUntilRelease_Offset;
    static readonly IntPtr bIgnoreAllPressedKeysUntilRelease_NativeProperty;
    public bool IgnoreAllPressedKeysUntilRelease;
    
    // BoolProperty /Script/EnhancedInput.ModifyContextOptions:bForceImmediately
    static readonly int bForceImmediately_Offset;
    static readonly IntPtr bForceImmediately_NativeProperty;
    public bool ForceImmediately;
    
    // BoolProperty /Script/EnhancedInput.ModifyContextOptions:bNotifyUserSettings
    static readonly int bNotifyUserSettings_Offset;
    static readonly IntPtr bNotifyUserSettings_NativeProperty;
    public bool NotifyUserSettings;
    
    
    public static readonly int NativeDataSize;
    static ModifyContextOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ModifyContextOptions");
        
        bIgnoreAllPressedKeysUntilRelease_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreAllPressedKeysUntilRelease");
        bIgnoreAllPressedKeysUntilRelease_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIgnoreAllPressedKeysUntilRelease");
        bForceImmediately_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceImmediately");
        bForceImmediately_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bForceImmediately");
        bNotifyUserSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNotifyUserSettings");
        bNotifyUserSettings_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bNotifyUserSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ModifyContextOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            IgnoreAllPressedKeysUntilRelease = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIgnoreAllPressedKeysUntilRelease_NativeProperty, bIgnoreAllPressedKeysUntilRelease_Offset);
            ForceImmediately = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bForceImmediately_NativeProperty, bForceImmediately_Offset);
            NotifyUserSettings = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bNotifyUserSettings_NativeProperty, bNotifyUserSettings_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIgnoreAllPressedKeysUntilRelease_NativeProperty, bIgnoreAllPressedKeysUntilRelease_Offset, IgnoreAllPressedKeysUntilRelease);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bForceImmediately_NativeProperty, bForceImmediately_Offset, ForceImmediately);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bNotifyUserSettings_NativeProperty, bNotifyUserSettings_Offset, NotifyUserSettings);
        }
    }
}

public static class ModifyContextOptionsMarshaler
{
    public static ModifyContextOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ModifyContextOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ModifyContextOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ModifyContextOptions.NativeDataSize;
    }
}