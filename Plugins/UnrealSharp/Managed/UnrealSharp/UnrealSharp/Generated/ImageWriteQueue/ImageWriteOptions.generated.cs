using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ImageWriteQueue;

[UStruct]
public partial struct ImageWriteOptions
{
    // EnumProperty /Script/ImageWriteQueue.ImageWriteOptions:Format
    static readonly int Format_Offset;
    public UnrealSharp.ImageWriteQueue.EDesiredImageFormat Format;
    
    // IntProperty /Script/ImageWriteQueue.ImageWriteOptions:CompressionQuality
    static readonly int CompressionQuality_Offset;
    public int CompressionQuality;
    
    // BoolProperty /Script/ImageWriteQueue.ImageWriteOptions:bOverwriteFile
    static readonly int bOverwriteFile_Offset;
    public bool OverwriteFile;
    
    // BoolProperty /Script/ImageWriteQueue.ImageWriteOptions:bAsync
    static readonly int bAsync_Offset;
    public bool Async;
    
    
    public static readonly int NativeDataSize;
    static ImageWriteOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ImageWriteOptions");
        
        Format_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Format");
        CompressionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CompressionQuality");
        bOverwriteFile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverwriteFile");
        bAsync_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAsync");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ImageWriteOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            Format = BlittableMarshaller<UnrealSharp.ImageWriteQueue.EDesiredImageFormat>.FromNative(IntPtr.Add(InNativeStruct, Format_Offset), 0, null);
            CompressionQuality = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, CompressionQuality_Offset), 0, null);
            OverwriteFile = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverwriteFile_Offset), 0, null);
            Async = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAsync_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ImageWriteQueue.EDesiredImageFormat>.ToNative(IntPtr.Add(Buffer, Format_Offset), 0, null, Format);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, CompressionQuality_Offset), 0, null, CompressionQuality);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverwriteFile_Offset), 0, null, OverwriteFile);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAsync_Offset), 0, null, Async);
        }
    }
}

public static class ImageWriteOptionsMarshaler
{
    public static ImageWriteOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ImageWriteOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ImageWriteOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ImageWriteOptions.NativeDataSize;
    }
}