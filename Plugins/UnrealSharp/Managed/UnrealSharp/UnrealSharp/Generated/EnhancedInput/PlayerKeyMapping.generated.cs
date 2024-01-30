using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct PlayerKeyMapping
{
    // NameProperty /Script/EnhancedInput.PlayerKeyMapping:MappingName
    static readonly int MappingName_Offset;
    public Name MappingName;
    
    // EnumProperty /Script/EnhancedInput.PlayerKeyMapping:Slot
    static readonly int Slot_Offset;
    public UnrealSharp.EnhancedInput.EPlayerMappableKeySlot Slot;
    
    // BoolProperty /Script/EnhancedInput.PlayerKeyMapping:bIsDirty
    static readonly int bIsDirty_Offset;
    static readonly IntPtr bIsDirty_NativeProperty;
    public bool IsDirty;
    
    // StructProperty /Script/EnhancedInput.PlayerKeyMapping:DefaultKey
    static readonly int DefaultKey_Offset;
    public UnrealSharp.InputCore.Key DefaultKey;
    
    // StructProperty /Script/EnhancedInput.PlayerKeyMapping:CurrentKey
    static readonly int CurrentKey_Offset;
    public UnrealSharp.InputCore.Key CurrentKey;
    
    // StructProperty /Script/EnhancedInput.PlayerKeyMapping:HardwareDeviceId
    static readonly int HardwareDeviceId_Offset;
    public UnrealSharp.Engine.HardwareDeviceIdentifier HardwareDeviceId;
    
    // ObjectProperty /Script/EnhancedInput.PlayerKeyMapping:AssociatedInputAction
    static readonly int AssociatedInputAction_Offset;
    public UnrealSharp.EnhancedInput.InputAction AssociatedInputAction;
    
    
    public static readonly int NativeDataSize;
    static PlayerKeyMapping()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PlayerKeyMapping");
        
        MappingName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MappingName");
        Slot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Slot");
        bIsDirty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsDirty");
        bIsDirty_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsDirty");
        DefaultKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultKey");
        CurrentKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurrentKey");
        HardwareDeviceId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardwareDeviceId");
        AssociatedInputAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssociatedInputAction");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PlayerKeyMapping(IntPtr InNativeStruct)
    {
        unsafe
        {
            MappingName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, MappingName_Offset), 0, null);
            Slot = BlittableMarshaller<UnrealSharp.EnhancedInput.EPlayerMappableKeySlot>.FromNative(IntPtr.Add(InNativeStruct, Slot_Offset), 0, null);
            IsDirty = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsDirty_NativeProperty, bIsDirty_Offset);
            DefaultKey = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, DefaultKey_Offset), 0, null);
            CurrentKey = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, CurrentKey_Offset), 0, null);
            HardwareDeviceId = UnrealSharp.Engine.HardwareDeviceIdentifierMarshaler.FromNative(IntPtr.Add(InNativeStruct, HardwareDeviceId_Offset), 0, null);
            AssociatedInputAction = ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.FromNative(IntPtr.Add(InNativeStruct, AssociatedInputAction_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, MappingName_Offset), 0, null, MappingName);
            BlittableMarshaller<UnrealSharp.EnhancedInput.EPlayerMappableKeySlot>.ToNative(IntPtr.Add(Buffer, Slot_Offset), 0, null, Slot);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsDirty_NativeProperty, bIsDirty_Offset, IsDirty);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, DefaultKey_Offset), 0, null, DefaultKey);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, CurrentKey_Offset), 0, null, CurrentKey);
            UnrealSharp.Engine.HardwareDeviceIdentifierMarshaler.ToNative(IntPtr.Add(Buffer, HardwareDeviceId_Offset), 0, null, HardwareDeviceId);
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.ToNative(IntPtr.Add(Buffer, AssociatedInputAction_Offset), 0, null, AssociatedInputAction);
        }
    }
}

public static class PlayerKeyMappingMarshaler
{
    public static PlayerKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PlayerKeyMapping(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PlayerKeyMapping obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PlayerKeyMapping.NativeDataSize;
    }
}