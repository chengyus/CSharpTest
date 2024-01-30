using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UStruct]
public partial struct PaperTileMetadata
{
    // NameProperty /Script/Paper2D.PaperTileMetadata:UserDataName
    static readonly int UserDataName_Offset;
    public Name UserDataName;
    
    
    public static readonly int NativeDataSize;
    static PaperTileMetadata()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PaperTileMetadata");
        
        UserDataName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserDataName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PaperTileMetadata(IntPtr InNativeStruct)
    {
        unsafe
        {
            UserDataName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, UserDataName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, UserDataName_Offset), 0, null, UserDataName);
        }
    }
}

public static class PaperTileMetadataMarshaler
{
    public static PaperTileMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PaperTileMetadata(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PaperTileMetadata obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PaperTileMetadata.NativeDataSize;
    }
}