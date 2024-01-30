using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct PlayerMappableKeyOptions
{
    // ObjectProperty /Script/EnhancedInput.PlayerMappableKeyOptions:Metadata
    static readonly int Metadata_Offset;
    public UnrealSharp.CoreUObject.Object Metadata;
    
    // NameProperty /Script/EnhancedInput.PlayerMappableKeyOptions:Name
    static readonly int Name_Offset;
    public Name Name;
    
    
    public static readonly int NativeDataSize;
    static PlayerMappableKeyOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PlayerMappableKeyOptions");
        
        Metadata_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Metadata");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PlayerMappableKeyOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            Metadata = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, Metadata_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, Metadata_Offset), 0, null, Metadata);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
        }
    }
}

public static class PlayerMappableKeyOptionsMarshaler
{
    public static PlayerMappableKeyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PlayerMappableKeyOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PlayerMappableKeyOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PlayerMappableKeyOptions.NativeDataSize;
    }
}