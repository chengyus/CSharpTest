using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwoBoneIKSimplePerItem
{
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:ItemA
    static readonly int ItemA_Offset;
    public UnrealSharp.ControlRig.RigElementKey ItemA;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:ItemB
    static readonly int ItemB_Offset;
    public UnrealSharp.ControlRig.RigElementKey ItemB;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:EffectorItem
    static readonly int EffectorItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey EffectorItem;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:Effector
    static readonly int Effector_Offset;
    public UnrealSharp.Transform Effector;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:SecondaryAxisWeight
    static readonly int SecondaryAxisWeight_Offset;
    public float SecondaryAxisWeight;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:PoleVector
    static readonly int PoleVector_Offset;
    public System.DoubleNumerics.Vector3 PoleVector;
    
    // EnumProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:PoleVectorKind
    static readonly int PoleVectorKind_Offset;
    public UnrealSharp.ControlRig.EControlRigVectorKind PoleVectorKind;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:PoleVectorSpace
    static readonly int PoleVectorSpace_Offset;
    public UnrealSharp.ControlRig.RigElementKey PoleVectorSpace;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:bEnableStretch
    static readonly int bEnableStretch_Offset;
    public bool EnableStretch;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:StretchStartRatio
    static readonly int StretchStartRatio_Offset;
    public float StretchStartRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:StretchMaximumRatio
    static readonly int StretchMaximumRatio_Offset;
    public float StretchMaximumRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:ItemALength
    static readonly int ItemALength_Offset;
    public float ItemALength;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:ItemBLength
    static readonly int ItemBLength_Offset;
    public float ItemBLength;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_TwoBoneIKSimple_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwoBoneIKSimplePerItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwoBoneIKSimplePerItem");
        
        ItemA_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemA");
        ItemB_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemB");
        EffectorItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorItem");
        Effector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Effector");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        SecondaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxis");
        SecondaryAxisWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxisWeight");
        PoleVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVector");
        PoleVectorKind_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorKind");
        PoleVectorSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorSpace");
        bEnableStretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableStretch");
        StretchStartRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchStartRatio");
        StretchMaximumRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchMaximumRatio");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        ItemALength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemALength");
        ItemBLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemBLength");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwoBoneIKSimplePerItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            ItemA = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, ItemA_Offset), 0, null);
            ItemB = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, ItemB_Offset), 0, null);
            EffectorItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, EffectorItem_Offset), 0, null);
            Effector = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Effector_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            SecondaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxis_Offset), 0, null);
            SecondaryAxisWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxisWeight_Offset), 0, null);
            PoleVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleVector_Offset), 0, null);
            PoleVectorKind = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorKind_Offset), 0, null);
            PoleVectorSpace = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, PoleVectorSpace_Offset), 0, null);
            EnableStretch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableStretch_Offset), 0, null);
            StretchStartRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchStartRatio_Offset), 0, null);
            StretchMaximumRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchMaximumRatio_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            ItemALength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ItemALength_Offset), 0, null);
            ItemBLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ItemBLength_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_TwoBoneIKSimple_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, ItemA_Offset), 0, null, ItemA);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, ItemB_Offset), 0, null, ItemB);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, EffectorItem_Offset), 0, null, EffectorItem);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Effector_Offset), 0, null, Effector);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAxis_Offset), 0, null, SecondaryAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SecondaryAxisWeight_Offset), 0, null, SecondaryAxisWeight);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleVector_Offset), 0, null, PoleVector);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.ToNative(IntPtr.Add(Buffer, PoleVectorKind_Offset), 0, null, PoleVectorKind);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, PoleVectorSpace_Offset), 0, null, PoleVectorSpace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableStretch_Offset), 0, null, EnableStretch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchStartRatio_Offset), 0, null, StretchStartRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchMaximumRatio_Offset), 0, null, StretchMaximumRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ItemALength_Offset), 0, null, ItemALength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ItemBLength_Offset), 0, null, ItemBLength);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            UnrealSharp.ControlRig.RigUnit_TwoBoneIKSimple_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_TwoBoneIKSimplePerItemMarshaler
{
    public static RigUnit_TwoBoneIKSimplePerItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwoBoneIKSimplePerItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwoBoneIKSimplePerItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwoBoneIKSimplePerItem.NativeDataSize;
    }
}