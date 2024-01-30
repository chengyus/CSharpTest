using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwoBoneIKSimpleVectors
{
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:Root
    static readonly int Root_Offset;
    public System.DoubleNumerics.Vector3 Root;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:PoleVector
    static readonly int PoleVector_Offset;
    public System.DoubleNumerics.Vector3 PoleVector;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:Effector
    static readonly int Effector_Offset;
    public System.DoubleNumerics.Vector3 Effector;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:bEnableStretch
    static readonly int bEnableStretch_Offset;
    public bool EnableStretch;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:StretchStartRatio
    static readonly int StretchStartRatio_Offset;
    public float StretchStartRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:StretchMaximumRatio
    static readonly int StretchMaximumRatio_Offset;
    public float StretchMaximumRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:BoneALength
    static readonly int BoneALength_Offset;
    public float BoneALength;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:BoneBLength
    static readonly int BoneBLength_Offset;
    public float BoneBLength;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors:Elbow
    static readonly int Elbow_Offset;
    public System.DoubleNumerics.Vector3 Elbow;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwoBoneIKSimpleVectors()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwoBoneIKSimpleVectors");
        
        Root_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Root");
        PoleVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVector");
        Effector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Effector");
        bEnableStretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableStretch");
        StretchStartRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchStartRatio");
        StretchMaximumRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchMaximumRatio");
        BoneALength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneALength");
        BoneBLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneBLength");
        Elbow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Elbow");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwoBoneIKSimpleVectors(IntPtr InNativeStruct)
    {
        unsafe
        {
            Root = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Root_Offset), 0, null);
            PoleVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleVector_Offset), 0, null);
            Effector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Effector_Offset), 0, null);
            EnableStretch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableStretch_Offset), 0, null);
            StretchStartRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchStartRatio_Offset), 0, null);
            StretchMaximumRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchMaximumRatio_Offset), 0, null);
            BoneALength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BoneALength_Offset), 0, null);
            BoneBLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BoneBLength_Offset), 0, null);
            Elbow = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Elbow_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Root_Offset), 0, null, Root);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleVector_Offset), 0, null, PoleVector);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Effector_Offset), 0, null, Effector);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableStretch_Offset), 0, null, EnableStretch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchStartRatio_Offset), 0, null, StretchStartRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchMaximumRatio_Offset), 0, null, StretchMaximumRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BoneALength_Offset), 0, null, BoneALength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BoneBLength_Offset), 0, null, BoneBLength);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Elbow_Offset), 0, null, Elbow);
        }
    }
}

public static class RigUnit_TwoBoneIKSimpleVectorsMarshaler
{
    public static RigUnit_TwoBoneIKSimpleVectors FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwoBoneIKSimpleVectors(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwoBoneIKSimpleVectors obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwoBoneIKSimpleVectors.NativeDataSize;
    }
}