using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_CopyBone
{
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyBone:bCopyTranslation
    static readonly int bCopyTranslation_Offset;
    public bool CopyTranslation;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyBone:bCopyRotation
    static readonly int bCopyRotation_Offset;
    public bool CopyRotation;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyBone:bCopyScale
    static readonly int bCopyScale_Offset;
    public bool CopyScale;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_CopyBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_CopyBone");
        
        bCopyTranslation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyTranslation");
        bCopyRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyRotation");
        bCopyScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyScale");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_CopyBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            CopyTranslation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyTranslation_Offset), 0, null);
            CopyRotation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyRotation_Offset), 0, null);
            CopyScale = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyScale_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyTranslation_Offset), 0, null, CopyTranslation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyRotation_Offset), 0, null, CopyRotation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyScale_Offset), 0, null, CopyScale);
        }
    }
}

public static class AnimNode_CopyBoneMarshaler
{
    public static AnimNode_CopyBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_CopyBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_CopyBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_CopyBone.NativeDataSize;
    }
}