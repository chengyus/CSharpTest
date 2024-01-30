using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct PlayerMappableKeyQueryOptions
{
    // NameProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:MappingName
    static readonly int MappingName_Offset;
    public Name MappingName;
    
    // StructProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:KeyToMatch
    static readonly int KeyToMatch_Offset;
    public UnrealSharp.InputCore.Key KeyToMatch;
    
    // EnumProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:SlotToMatch
    static readonly int SlotToMatch_Offset;
    public UnrealSharp.EnhancedInput.EPlayerMappableKeySlot SlotToMatch;
    
    // BoolProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:bMatchBasicKeyTypes
    static readonly int bMatchBasicKeyTypes_Offset;
    static readonly IntPtr bMatchBasicKeyTypes_NativeProperty;
    public bool MatchBasicKeyTypes;
    
    // BoolProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:bMatchKeyAxisType
    static readonly int bMatchKeyAxisType_Offset;
    static readonly IntPtr bMatchKeyAxisType_NativeProperty;
    public bool MatchKeyAxisType;
    
    // EnumProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:RequiredDeviceType
    static readonly int RequiredDeviceType_Offset;
    public UnrealSharp.Engine.EHardwareDevicePrimaryType RequiredDeviceType;
    
    // IntProperty /Script/EnhancedInput.PlayerMappableKeyQueryOptions:RequiredDeviceFlags
    static readonly int RequiredDeviceFlags_Offset;
    public int RequiredDeviceFlags;
    
    
    public static readonly int NativeDataSize;
    static PlayerMappableKeyQueryOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PlayerMappableKeyQueryOptions");
        
        MappingName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MappingName");
        KeyToMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeyToMatch");
        SlotToMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SlotToMatch");
        bMatchBasicKeyTypes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMatchBasicKeyTypes");
        bMatchBasicKeyTypes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMatchBasicKeyTypes");
        bMatchKeyAxisType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMatchKeyAxisType");
        bMatchKeyAxisType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMatchKeyAxisType");
        RequiredDeviceType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RequiredDeviceType");
        RequiredDeviceFlags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RequiredDeviceFlags");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PlayerMappableKeyQueryOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            MappingName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, MappingName_Offset), 0, null);
            KeyToMatch = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, KeyToMatch_Offset), 0, null);
            SlotToMatch = BlittableMarshaller<UnrealSharp.EnhancedInput.EPlayerMappableKeySlot>.FromNative(IntPtr.Add(InNativeStruct, SlotToMatch_Offset), 0, null);
            MatchBasicKeyTypes = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMatchBasicKeyTypes_NativeProperty, bMatchBasicKeyTypes_Offset);
            MatchKeyAxisType = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMatchKeyAxisType_NativeProperty, bMatchKeyAxisType_Offset);
            RequiredDeviceType = BlittableMarshaller<UnrealSharp.Engine.EHardwareDevicePrimaryType>.FromNative(IntPtr.Add(InNativeStruct, RequiredDeviceType_Offset), 0, null);
            RequiredDeviceFlags = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RequiredDeviceFlags_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, MappingName_Offset), 0, null, MappingName);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, KeyToMatch_Offset), 0, null, KeyToMatch);
            BlittableMarshaller<UnrealSharp.EnhancedInput.EPlayerMappableKeySlot>.ToNative(IntPtr.Add(Buffer, SlotToMatch_Offset), 0, null, SlotToMatch);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMatchBasicKeyTypes_NativeProperty, bMatchBasicKeyTypes_Offset, MatchBasicKeyTypes);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMatchKeyAxisType_NativeProperty, bMatchKeyAxisType_Offset, MatchKeyAxisType);
            BlittableMarshaller<UnrealSharp.Engine.EHardwareDevicePrimaryType>.ToNative(IntPtr.Add(Buffer, RequiredDeviceType_Offset), 0, null, RequiredDeviceType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RequiredDeviceFlags_Offset), 0, null, RequiredDeviceFlags);
        }
    }
}

public static class PlayerMappableKeyQueryOptionsMarshaler
{
    public static PlayerMappableKeyQueryOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PlayerMappableKeyQueryOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PlayerMappableKeyQueryOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PlayerMappableKeyQueryOptions.NativeDataSize;
    }
}