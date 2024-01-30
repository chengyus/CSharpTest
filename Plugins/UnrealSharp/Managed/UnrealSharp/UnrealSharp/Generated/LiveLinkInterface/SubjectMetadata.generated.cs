using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct SubjectMetadata
{
    // StructProperty /Script/LiveLinkInterface.SubjectMetadata:SceneTimecode
    static readonly int SceneTimecode_Offset;
    public UnrealSharp.CoreUObject.Timecode SceneTimecode;
    
    // StructProperty /Script/LiveLinkInterface.SubjectMetadata:SceneFramerate
    static readonly int SceneFramerate_Offset;
    public UnrealSharp.CoreUObject.FrameRate SceneFramerate;
    
    
    public static readonly int NativeDataSize;
    static SubjectMetadata()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubjectMetadata");
        
        SceneTimecode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SceneTimecode");
        SceneFramerate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SceneFramerate");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubjectMetadata(IntPtr InNativeStruct)
    {
        unsafe
        {
            SceneTimecode = UnrealSharp.CoreUObject.TimecodeMarshaler.FromNative(IntPtr.Add(InNativeStruct, SceneTimecode_Offset), 0, null);
            SceneFramerate = BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.FromNative(IntPtr.Add(InNativeStruct, SceneFramerate_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.TimecodeMarshaler.ToNative(IntPtr.Add(Buffer, SceneTimecode_Offset), 0, null, SceneTimecode);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(Buffer, SceneFramerate_Offset), 0, null, SceneFramerate);
        }
    }
}

public static class SubjectMetadataMarshaler
{
    public static SubjectMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubjectMetadata(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubjectMetadata obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubjectMetadata.NativeDataSize;
    }
}