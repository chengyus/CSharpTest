using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UStruct]
public partial struct PaperSpriteSocket
{
    // StructProperty /Script/Paper2D.PaperSpriteSocket:LocalTransform
    static readonly int LocalTransform_Offset;
    public UnrealSharp.Transform LocalTransform;
    
    // NameProperty /Script/Paper2D.PaperSpriteSocket:SocketName
    static readonly int SocketName_Offset;
    public Name SocketName;
    
    
    public static readonly int NativeDataSize;
    static PaperSpriteSocket()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PaperSpriteSocket");
        
        LocalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalTransform");
        SocketName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SocketName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PaperSpriteSocket(IntPtr InNativeStruct)
    {
        unsafe
        {
            LocalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, LocalTransform_Offset), 0, null);
            SocketName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SocketName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, LocalTransform_Offset), 0, null, LocalTransform);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SocketName_Offset), 0, null, SocketName);
        }
    }
}

public static class PaperSpriteSocketMarshaler
{
    public static PaperSpriteSocket FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PaperSpriteSocket(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PaperSpriteSocket obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PaperSpriteSocket.NativeDataSize;
    }
}