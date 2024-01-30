using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SlateSound
{
    // ObjectProperty /Script/SlateCore.SlateSound:ResourceObject
    static readonly int ResourceObject_Offset;
    public UnrealSharp.CoreUObject.Object ResourceObject;
    
    
    public static readonly int NativeDataSize;
    static SlateSound()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SlateSound");
        
        ResourceObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ResourceObject");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SlateSound(IntPtr InNativeStruct)
    {
        unsafe
        {
            ResourceObject = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, ResourceObject_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, ResourceObject_Offset), 0, null, ResourceObject);
        }
    }
}

public static class SlateSoundMarshaler
{
    public static SlateSound FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SlateSound(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SlateSound obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SlateSound.NativeDataSize;
    }
}