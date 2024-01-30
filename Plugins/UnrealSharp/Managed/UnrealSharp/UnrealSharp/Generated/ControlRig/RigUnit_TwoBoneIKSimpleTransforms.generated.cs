using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwoBoneIKSimpleTransforms
{
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:Root
    static readonly int Root_Offset;
    public UnrealSharp.Transform Root;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:PoleVector
    static readonly int PoleVector_Offset;
    public System.DoubleNumerics.Vector3 PoleVector;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:Effector
    static readonly int Effector_Offset;
    public UnrealSharp.Transform Effector;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:SecondaryAxisWeight
    static readonly int SecondaryAxisWeight_Offset;
    public float SecondaryAxisWeight;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:bEnableStretch
    static readonly int bEnableStretch_Offset;
    public bool EnableStretch;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:StretchStartRatio
    static readonly int StretchStartRatio_Offset;
    public float StretchStartRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:StretchMaximumRatio
    static readonly int StretchMaximumRatio_Offset;
    public float StretchMaximumRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:BoneALength
    static readonly int BoneALength_Offset;
    public float BoneALength;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:BoneBLength
    static readonly int BoneBLength_Offset;
    public float BoneBLength;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms:Elbow
    static readonly int Elbow_Offset;
    public UnrealSharp.Transform Elbow;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwoBoneIKSimpleTransforms()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwoBoneIKSimpleTransforms");
        
        Root_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Root");
        PoleVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVector");
        Effector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Effector");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        SecondaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxis");
        SecondaryAxisWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxisWeight");
        bEnableStretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableStretch");
        StretchStartRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchStartRatio");
        StretchMaximumRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchMaximumRatio");
        BoneALength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneALength");
        BoneBLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneBLength");
        Elbow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Elbow");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwoBoneIKSimpleTransforms(IntPtr InNativeStruct)
    {
        unsafe
        {
            Root = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Root_Offset), 0, null);
            PoleVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleVector_Offset), 0, null);
            Effector = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Effector_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            SecondaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxis_Offset), 0, null);
            SecondaryAxisWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxisWeight_Offset), 0, null);
            EnableStretch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableStretch_Offset), 0, null);
            StretchStartRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchStartRatio_Offset), 0, null);
            StretchMaximumRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchMaximumRatio_Offset), 0, null);
            BoneALength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BoneALength_Offset), 0, null);
            BoneBLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BoneBLength_Offset), 0, null);
            Elbow = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Elbow_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Root_Offset), 0, null, Root);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleVector_Offset), 0, null, PoleVector);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Effector_Offset), 0, null, Effector);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAxis_Offset), 0, null, SecondaryAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SecondaryAxisWeight_Offset), 0, null, SecondaryAxisWeight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableStretch_Offset), 0, null, EnableStretch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchStartRatio_Offset), 0, null, StretchStartRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchMaximumRatio_Offset), 0, null, StretchMaximumRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BoneALength_Offset), 0, null, BoneALength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BoneBLength_Offset), 0, null, BoneBLength);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Elbow_Offset), 0, null, Elbow);
        }
    }
}

public static class RigUnit_TwoBoneIKSimpleTransformsMarshaler
{
    public static RigUnit_TwoBoneIKSimpleTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwoBoneIKSimpleTransforms(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwoBoneIKSimpleTransforms obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwoBoneIKSimpleTransforms.NativeDataSize;
    }
}