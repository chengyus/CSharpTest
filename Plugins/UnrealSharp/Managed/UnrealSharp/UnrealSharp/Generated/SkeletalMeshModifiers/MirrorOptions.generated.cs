using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SkeletalMeshModifiers;

[UStruct]
public partial struct MirrorOptions
{
    // ByteProperty /Script/SkeletalMeshModifiers.MirrorOptions:MirrorAxis
    static readonly int MirrorAxis_Offset;
    public UnrealSharp.CoreUObject.EAxis MirrorAxis;
    
    // BoolProperty /Script/SkeletalMeshModifiers.MirrorOptions:bMirrorRotation
    static readonly int bMirrorRotation_Offset;
    public bool MirrorRotation;
    
    // BoolProperty /Script/SkeletalMeshModifiers.MirrorOptions:bMirrorChildren
    static readonly int bMirrorChildren_Offset;
    public bool MirrorChildren;
    
    
    public static readonly int NativeDataSize;
    static MirrorOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MirrorOptions");
        
        MirrorAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirrorAxis");
        bMirrorRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMirrorRotation");
        bMirrorChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMirrorChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MirrorOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            MirrorAxis = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, MirrorAxis_Offset), 0, null);
            MirrorRotation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMirrorRotation_Offset), 0, null);
            MirrorChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMirrorChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, MirrorAxis_Offset), 0, null, MirrorAxis);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMirrorRotation_Offset), 0, null, MirrorRotation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMirrorChildren_Offset), 0, null, MirrorChildren);
        }
    }
}

public static class MirrorOptionsMarshaler
{
    public static MirrorOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MirrorOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MirrorOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MirrorOptions.NativeDataSize;
    }
}