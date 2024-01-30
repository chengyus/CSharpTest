using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct MapPlayerKeyArgs
{
    // NameProperty /Script/EnhancedInput.MapPlayerKeyArgs:MappingName
    static readonly int MappingName_Offset;
    public Name MappingName;
    
    // EnumProperty /Script/EnhancedInput.MapPlayerKeyArgs:Slot
    static readonly int Slot_Offset;
    public UnrealSharp.EnhancedInput.EPlayerMappableKeySlot Slot;
    
    // StructProperty /Script/EnhancedInput.MapPlayerKeyArgs:NewKey
    static readonly int NewKey_Offset;
    public UnrealSharp.InputCore.Key NewKey;
    
    // NameProperty /Script/EnhancedInput.MapPlayerKeyArgs:HardwareDeviceId
    static readonly int HardwareDeviceId_Offset;
    public Name HardwareDeviceId;
    
    // StructProperty /Script/EnhancedInput.MapPlayerKeyArgs:ProfileId
    static readonly int ProfileId_Offset;
    public UnrealSharp.GameplayTags.GameplayTag ProfileId;
    
    // BoolProperty /Script/EnhancedInput.MapPlayerKeyArgs:bCreateMatchingSlotIfNeeded
    static readonly int bCreateMatchingSlotIfNeeded_Offset;
    static readonly IntPtr bCreateMatchingSlotIfNeeded_NativeProperty;
    public bool CreateMatchingSlotIfNeeded;
    
    // BoolProperty /Script/EnhancedInput.MapPlayerKeyArgs:bDeferOnSettingsChangedBroadcast
    static readonly int bDeferOnSettingsChangedBroadcast_Offset;
    static readonly IntPtr bDeferOnSettingsChangedBroadcast_NativeProperty;
    public bool DeferOnSettingsChangedBroadcast;
    
    
    public static readonly int NativeDataSize;
    static MapPlayerKeyArgs()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MapPlayerKeyArgs");
        
        MappingName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MappingName");
        Slot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Slot");
        NewKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NewKey");
        HardwareDeviceId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardwareDeviceId");
        ProfileId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProfileId");
        bCreateMatchingSlotIfNeeded_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCreateMatchingSlotIfNeeded");
        bCreateMatchingSlotIfNeeded_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCreateMatchingSlotIfNeeded");
        bDeferOnSettingsChangedBroadcast_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDeferOnSettingsChangedBroadcast");
        bDeferOnSettingsChangedBroadcast_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDeferOnSettingsChangedBroadcast");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MapPlayerKeyArgs(IntPtr InNativeStruct)
    {
        unsafe
        {
            MappingName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, MappingName_Offset), 0, null);
            Slot = BlittableMarshaller<UnrealSharp.EnhancedInput.EPlayerMappableKeySlot>.FromNative(IntPtr.Add(InNativeStruct, Slot_Offset), 0, null);
            NewKey = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, NewKey_Offset), 0, null);
            HardwareDeviceId = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, HardwareDeviceId_Offset), 0, null);
            ProfileId = UnrealSharp.GameplayTags.GameplayTagMarshaler.FromNative(IntPtr.Add(InNativeStruct, ProfileId_Offset), 0, null);
            CreateMatchingSlotIfNeeded = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCreateMatchingSlotIfNeeded_NativeProperty, bCreateMatchingSlotIfNeeded_Offset);
            DeferOnSettingsChangedBroadcast = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDeferOnSettingsChangedBroadcast_NativeProperty, bDeferOnSettingsChangedBroadcast_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, MappingName_Offset), 0, null, MappingName);
            BlittableMarshaller<UnrealSharp.EnhancedInput.EPlayerMappableKeySlot>.ToNative(IntPtr.Add(Buffer, Slot_Offset), 0, null, Slot);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, NewKey_Offset), 0, null, NewKey);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, HardwareDeviceId_Offset), 0, null, HardwareDeviceId);
            UnrealSharp.GameplayTags.GameplayTagMarshaler.ToNative(IntPtr.Add(Buffer, ProfileId_Offset), 0, null, ProfileId);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCreateMatchingSlotIfNeeded_NativeProperty, bCreateMatchingSlotIfNeeded_Offset, CreateMatchingSlotIfNeeded);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDeferOnSettingsChangedBroadcast_NativeProperty, bDeferOnSettingsChangedBroadcast_Offset, DeferOnSettingsChangedBroadcast);
        }
    }
}

public static class MapPlayerKeyArgsMarshaler
{
    public static MapPlayerKeyArgs FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MapPlayerKeyArgs(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MapPlayerKeyArgs obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MapPlayerKeyArgs.NativeDataSize;
    }
}