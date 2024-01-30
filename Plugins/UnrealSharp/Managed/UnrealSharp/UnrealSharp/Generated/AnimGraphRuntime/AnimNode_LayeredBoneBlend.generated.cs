using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_LayeredBoneBlend
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:BasePose
    static readonly int BasePose_Offset;
    public UnrealSharp.Engine.PoseLink BasePose;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:bMeshSpaceRotationBlend
    static readonly int bMeshSpaceRotationBlend_Offset;
    public bool MeshSpaceRotationBlend;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:bMeshSpaceScaleBlend
    static readonly int bMeshSpaceScaleBlend_Offset;
    public bool MeshSpaceScaleBlend;
    
    // ByteProperty /Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:CurveBlendOption
    static readonly int CurveBlendOption_Offset;
    public UnrealSharp.Engine.ECurveBlendOption CurveBlendOption;
    
    // IntProperty /Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:LODThreshold
    static readonly int LODThreshold_Offset;
    public int LODThreshold;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_LayeredBoneBlend()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_LayeredBoneBlend");
        
        BasePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BasePose");
        bMeshSpaceRotationBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMeshSpaceRotationBlend");
        bMeshSpaceScaleBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMeshSpaceScaleBlend");
        CurveBlendOption_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveBlendOption");
        LODThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LODThreshold");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_LayeredBoneBlend(IntPtr InNativeStruct)
    {
        unsafe
        {
            BasePose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, BasePose_Offset), 0, null);
            MeshSpaceRotationBlend = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMeshSpaceRotationBlend_Offset), 0, null);
            MeshSpaceScaleBlend = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMeshSpaceScaleBlend_Offset), 0, null);
            CurveBlendOption = BlittableMarshaller<UnrealSharp.Engine.ECurveBlendOption>.FromNative(IntPtr.Add(InNativeStruct, CurveBlendOption_Offset), 0, null);
            LODThreshold = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LODThreshold_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, BasePose_Offset), 0, null, BasePose);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMeshSpaceRotationBlend_Offset), 0, null, MeshSpaceRotationBlend);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMeshSpaceScaleBlend_Offset), 0, null, MeshSpaceScaleBlend);
            BlittableMarshaller<UnrealSharp.Engine.ECurveBlendOption>.ToNative(IntPtr.Add(Buffer, CurveBlendOption_Offset), 0, null, CurveBlendOption);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LODThreshold_Offset), 0, null, LODThreshold);
        }
    }
}

public static class AnimNode_LayeredBoneBlendMarshaler
{
    public static AnimNode_LayeredBoneBlend FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_LayeredBoneBlend(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_LayeredBoneBlend obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_LayeredBoneBlend.NativeDataSize;
    }
}