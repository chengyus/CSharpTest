using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UStruct]
public partial struct TransformConstraint
{
    // StructProperty /Script/AnimationCore.TransformConstraint:Operator
    static readonly int Operator_Offset;
    public UnrealSharp.AnimationCore.ConstraintDescription Operator;
    
    // NameProperty /Script/AnimationCore.TransformConstraint:SourceNode
    static readonly int SourceNode_Offset;
    public Name SourceNode;
    
    // NameProperty /Script/AnimationCore.TransformConstraint:TargetNode
    static readonly int TargetNode_Offset;
    public Name TargetNode;
    
    // FloatProperty /Script/AnimationCore.TransformConstraint:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/AnimationCore.TransformConstraint:bMaintainOffset
    static readonly int bMaintainOffset_Offset;
    public bool MaintainOffset;
    
    
    public static readonly int NativeDataSize;
    static TransformConstraint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TransformConstraint");
        
        Operator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Operator");
        SourceNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceNode");
        TargetNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetNode");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bMaintainOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaintainOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TransformConstraint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Operator = UnrealSharp.AnimationCore.ConstraintDescriptionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Operator_Offset), 0, null);
            SourceNode = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SourceNode_Offset), 0, null);
            TargetNode = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, TargetNode_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            MaintainOffset = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaintainOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.AnimationCore.ConstraintDescriptionMarshaler.ToNative(IntPtr.Add(Buffer, Operator_Offset), 0, null, Operator);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SourceNode_Offset), 0, null, SourceNode);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, TargetNode_Offset), 0, null, TargetNode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMaintainOffset_Offset), 0, null, MaintainOffset);
        }
    }
}

public static class TransformConstraintMarshaler
{
    public static TransformConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TransformConstraint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TransformConstraint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TransformConstraint.NativeDataSize;
    }
}