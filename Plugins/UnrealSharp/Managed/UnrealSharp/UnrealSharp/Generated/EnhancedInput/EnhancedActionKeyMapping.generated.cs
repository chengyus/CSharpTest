using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct EnhancedActionKeyMapping
{
    // StructProperty /Script/EnhancedInput.EnhancedActionKeyMapping:PlayerMappableOptions
    static readonly int PlayerMappableOptions_Offset;
    public UnrealSharp.EnhancedInput.PlayerMappableKeyOptions PlayerMappableOptions;
    
    // ObjectProperty /Script/EnhancedInput.EnhancedActionKeyMapping:Action
    static readonly int Action_Offset;
    public UnrealSharp.EnhancedInput.InputAction Action;
    
    // StructProperty /Script/EnhancedInput.EnhancedActionKeyMapping:Key
    static readonly int Key_Offset;
    public UnrealSharp.InputCore.Key Key;
    
    // BoolProperty /Script/EnhancedInput.EnhancedActionKeyMapping:bIsPlayerMappable
    static readonly int bIsPlayerMappable_Offset;
    static readonly IntPtr bIsPlayerMappable_NativeProperty;
    public bool IsPlayerMappable;
    
    
    public static readonly int NativeDataSize;
    static EnhancedActionKeyMapping()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EnhancedActionKeyMapping");
        
        PlayerMappableOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayerMappableOptions");
        Action_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Action");
        Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Key");
        bIsPlayerMappable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsPlayerMappable");
        bIsPlayerMappable_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsPlayerMappable");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EnhancedActionKeyMapping(IntPtr InNativeStruct)
    {
        unsafe
        {
            PlayerMappableOptions = UnrealSharp.EnhancedInput.PlayerMappableKeyOptionsMarshaler.FromNative(IntPtr.Add(InNativeStruct, PlayerMappableOptions_Offset), 0, null);
            Action = ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.FromNative(IntPtr.Add(InNativeStruct, Action_Offset), 0, null);
            Key = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Key_Offset), 0, null);
            IsPlayerMappable = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsPlayerMappable_NativeProperty, bIsPlayerMappable_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.EnhancedInput.PlayerMappableKeyOptionsMarshaler.ToNative(IntPtr.Add(Buffer, PlayerMappableOptions_Offset), 0, null, PlayerMappableOptions);
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.ToNative(IntPtr.Add(Buffer, Action_Offset), 0, null, Action);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, Key_Offset), 0, null, Key);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsPlayerMappable_NativeProperty, bIsPlayerMappable_Offset, IsPlayerMappable);
        }
    }
}

public static class EnhancedActionKeyMappingMarshaler
{
    public static EnhancedActionKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EnhancedActionKeyMapping(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EnhancedActionKeyMapping obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EnhancedActionKeyMapping.NativeDataSize;
    }
}