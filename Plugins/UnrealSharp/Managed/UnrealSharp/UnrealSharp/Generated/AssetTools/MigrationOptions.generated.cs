using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AssetTools;

[UStruct]
public partial struct MigrationOptions
{
    // EnumProperty /Script/AssetTools.MigrationOptions:AssetConflict
    static readonly int AssetConflict_Offset;
    public UnrealSharp.AssetTools.EAssetMigrationConflict AssetConflict;
    
    
    public static readonly int NativeDataSize;
    static MigrationOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MigrationOptions");
        
        AssetConflict_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetConflict");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MigrationOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            AssetConflict = BlittableMarshaller<UnrealSharp.AssetTools.EAssetMigrationConflict>.FromNative(IntPtr.Add(InNativeStruct, AssetConflict_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AssetTools.EAssetMigrationConflict>.ToNative(IntPtr.Add(Buffer, AssetConflict_Offset), 0, null, AssetConflict);
        }
    }
}

public static class MigrationOptionsMarshaler
{
    public static MigrationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MigrationOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MigrationOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MigrationOptions.NativeDataSize;
    }
}