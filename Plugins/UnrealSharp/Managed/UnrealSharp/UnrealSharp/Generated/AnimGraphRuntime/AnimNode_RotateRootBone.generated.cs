using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_RotateRootBone
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:BasePose
    static readonly int BasePose_Offset;
    public UnrealSharp.Engine.PoseLink BasePose;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:Pitch
    static readonly int Pitch_Offset;
    public float Pitch;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:Yaw
    static readonly int Yaw_Offset;
    public float Yaw;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:PitchScaleBiasClamp
    static readonly int PitchScaleBiasClamp_Offset;
    public UnrealSharp.Engine.InputScaleBiasClamp PitchScaleBiasClamp;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:YawScaleBiasClamp
    static readonly int YawScaleBiasClamp_Offset;
    public UnrealSharp.Engine.InputScaleBiasClamp YawScaleBiasClamp;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:MeshToComponent
    static readonly int MeshToComponent_Offset;
    public UnrealSharp.Rotator MeshToComponent;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_RotateRootBone:bRotateRootMotionAttribute
    static readonly int bRotateRootMotionAttribute_Offset;
    public bool RotateRootMotionAttribute;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_RotateRootBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_RotateRootBone");
        
        BasePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BasePose");
        Pitch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pitch");
        Yaw_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Yaw");
        PitchScaleBiasClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PitchScaleBiasClamp");
        YawScaleBiasClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "YawScaleBiasClamp");
        MeshToComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshToComponent");
        bRotateRootMotionAttribute_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRotateRootMotionAttribute");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_RotateRootBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            BasePose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, BasePose_Offset), 0, null);
            Pitch = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Pitch_Offset), 0, null);
            Yaw = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Yaw_Offset), 0, null);
            PitchScaleBiasClamp = UnrealSharp.Engine.InputScaleBiasClampMarshaler.FromNative(IntPtr.Add(InNativeStruct, PitchScaleBiasClamp_Offset), 0, null);
            YawScaleBiasClamp = UnrealSharp.Engine.InputScaleBiasClampMarshaler.FromNative(IntPtr.Add(InNativeStruct, YawScaleBiasClamp_Offset), 0, null);
            MeshToComponent = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, MeshToComponent_Offset), 0, null);
            RotateRootMotionAttribute = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRotateRootMotionAttribute_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, BasePose_Offset), 0, null, BasePose);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Pitch_Offset), 0, null, Pitch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Yaw_Offset), 0, null, Yaw);
            UnrealSharp.Engine.InputScaleBiasClampMarshaler.ToNative(IntPtr.Add(Buffer, PitchScaleBiasClamp_Offset), 0, null, PitchScaleBiasClamp);
            UnrealSharp.Engine.InputScaleBiasClampMarshaler.ToNative(IntPtr.Add(Buffer, YawScaleBiasClamp_Offset), 0, null, YawScaleBiasClamp);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, MeshToComponent_Offset), 0, null, MeshToComponent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRotateRootMotionAttribute_Offset), 0, null, RotateRootMotionAttribute);
        }
    }
}

public static class AnimNode_RotateRootBoneMarshaler
{
    public static AnimNode_RotateRootBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_RotateRootBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_RotateRootBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_RotateRootBone.NativeDataSize;
    }
}