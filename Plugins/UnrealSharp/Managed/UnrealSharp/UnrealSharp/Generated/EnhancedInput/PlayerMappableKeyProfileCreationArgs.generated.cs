using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct PlayerMappableKeyProfileCreationArgs
{
    // ClassProperty /Script/EnhancedInput.PlayerMappableKeyProfileCreationArgs:ProfileType
    static readonly int ProfileType_Offset;
    public SubclassOf<UnrealSharp.EnhancedInput.EnhancedPlayerMappableKeyProfile> ProfileType;
    
    // StructProperty /Script/EnhancedInput.PlayerMappableKeyProfileCreationArgs:ProfileIdentifier
    static readonly int ProfileIdentifier_Offset;
    public UnrealSharp.GameplayTags.GameplayTag ProfileIdentifier;
    
    // StructProperty /Script/EnhancedInput.PlayerMappableKeyProfileCreationArgs:UserId
    static readonly int UserId_Offset;
    public UnrealSharp.CoreUObject.PlatformUserId UserId;
    
    // BoolProperty /Script/EnhancedInput.PlayerMappableKeyProfileCreationArgs:bSetAsCurrentProfile
    static readonly int bSetAsCurrentProfile_Offset;
    static readonly IntPtr bSetAsCurrentProfile_NativeProperty;
    public bool SetAsCurrentProfile;
    
    
    public static readonly int NativeDataSize;
    static PlayerMappableKeyProfileCreationArgs()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PlayerMappableKeyProfileCreationArgs");
        
        ProfileType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProfileType");
        ProfileIdentifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProfileIdentifier");
        UserId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserId");
        bSetAsCurrentProfile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSetAsCurrentProfile");
        bSetAsCurrentProfile_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSetAsCurrentProfile");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PlayerMappableKeyProfileCreationArgs(IntPtr InNativeStruct)
    {
        unsafe
        {
            ProfileType = SubclassOfMarshaller<UnrealSharp.EnhancedInput.EnhancedPlayerMappableKeyProfile>.FromNative(IntPtr.Add(InNativeStruct, ProfileType_Offset), 0, null);
            ProfileIdentifier = UnrealSharp.GameplayTags.GameplayTagMarshaler.FromNative(IntPtr.Add(InNativeStruct, ProfileIdentifier_Offset), 0, null);
            UserId = UnrealSharp.CoreUObject.PlatformUserIdMarshaler.FromNative(IntPtr.Add(InNativeStruct, UserId_Offset), 0, null);
            SetAsCurrentProfile = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSetAsCurrentProfile_NativeProperty, bSetAsCurrentProfile_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.EnhancedInput.EnhancedPlayerMappableKeyProfile>.ToNative(IntPtr.Add(Buffer, ProfileType_Offset), 0, null, ProfileType);
            UnrealSharp.GameplayTags.GameplayTagMarshaler.ToNative(IntPtr.Add(Buffer, ProfileIdentifier_Offset), 0, null, ProfileIdentifier);
            UnrealSharp.CoreUObject.PlatformUserIdMarshaler.ToNative(IntPtr.Add(Buffer, UserId_Offset), 0, null, UserId);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSetAsCurrentProfile_NativeProperty, bSetAsCurrentProfile_Offset, SetAsCurrentProfile);
        }
    }
}

public static class PlayerMappableKeyProfileCreationArgsMarshaler
{
    public static PlayerMappableKeyProfileCreationArgs FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PlayerMappableKeyProfileCreationArgs(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PlayerMappableKeyProfileCreationArgs obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PlayerMappableKeyProfileCreationArgs.NativeDataSize;
    }
}