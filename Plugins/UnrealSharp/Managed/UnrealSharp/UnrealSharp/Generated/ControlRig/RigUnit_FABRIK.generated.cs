using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_FABRIK
{
    // NameProperty /Script/ControlRig.RigUnit_FABRIK:StartBone
    static readonly int StartBone_Offset;
    public Name StartBone;
    
    // NameProperty /Script/ControlRig.RigUnit_FABRIK:EffectorBone
    static readonly int EffectorBone_Offset;
    public Name EffectorBone;
    
    // StructProperty /Script/ControlRig.RigUnit_FABRIK:EffectorTransform
    static readonly int EffectorTransform_Offset;
    public UnrealSharp.Transform EffectorTransform;
    
    // FloatProperty /Script/ControlRig.RigUnit_FABRIK:Precision
    static readonly int Precision_Offset;
    public float Precision;
    
    // FloatProperty /Script/ControlRig.RigUnit_FABRIK:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_FABRIK:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // IntProperty /Script/ControlRig.RigUnit_FABRIK:MaxIterations
    static readonly int MaxIterations_Offset;
    public int MaxIterations;
    
    // BoolProperty /Script/ControlRig.RigUnit_FABRIK:bSetEffectorTransform
    static readonly int bSetEffectorTransform_Offset;
    public bool SetEffectorTransform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FABRIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FABRIK");
        
        StartBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartBone");
        EffectorBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorBone");
        EffectorTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorTransform");
        Precision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Precision");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        MaxIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxIterations");
        bSetEffectorTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSetEffectorTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FABRIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartBone_Offset), 0, null);
            EffectorBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EffectorBone_Offset), 0, null);
            EffectorTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, EffectorTransform_Offset), 0, null);
            Precision = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Precision_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            MaxIterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxIterations_Offset), 0, null);
            SetEffectorTransform = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSetEffectorTransform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StartBone_Offset), 0, null, StartBone);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EffectorBone_Offset), 0, null, EffectorBone);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, EffectorTransform_Offset), 0, null, EffectorTransform);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Precision_Offset), 0, null, Precision);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxIterations_Offset), 0, null, MaxIterations);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSetEffectorTransform_Offset), 0, null, SetEffectorTransform);
        }
    }
}

public static class RigUnit_FABRIKMarshaler
{
    public static RigUnit_FABRIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FABRIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FABRIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FABRIK.NativeDataSize;
    }
}