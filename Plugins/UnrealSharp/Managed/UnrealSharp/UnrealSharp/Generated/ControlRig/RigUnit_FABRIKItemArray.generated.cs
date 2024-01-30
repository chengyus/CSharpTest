using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_FABRIKItemArray
{
    // StructProperty /Script/ControlRig.RigUnit_FABRIKItemArray:EffectorTransform
    static readonly int EffectorTransform_Offset;
    public UnrealSharp.Transform EffectorTransform;
    
    // FloatProperty /Script/ControlRig.RigUnit_FABRIKItemArray:Precision
    static readonly int Precision_Offset;
    public float Precision;
    
    // FloatProperty /Script/ControlRig.RigUnit_FABRIKItemArray:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_FABRIKItemArray:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // IntProperty /Script/ControlRig.RigUnit_FABRIKItemArray:MaxIterations
    static readonly int MaxIterations_Offset;
    public int MaxIterations;
    
    // BoolProperty /Script/ControlRig.RigUnit_FABRIKItemArray:bSetEffectorTransform
    static readonly int bSetEffectorTransform_Offset;
    public bool SetEffectorTransform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FABRIKItemArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FABRIKItemArray");
        
        EffectorTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorTransform");
        Precision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Precision");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        MaxIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxIterations");
        bSetEffectorTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSetEffectorTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FABRIKItemArray(IntPtr InNativeStruct)
    {
        unsafe
        {
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
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, EffectorTransform_Offset), 0, null, EffectorTransform);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Precision_Offset), 0, null, Precision);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxIterations_Offset), 0, null, MaxIterations);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSetEffectorTransform_Offset), 0, null, SetEffectorTransform);
        }
    }
}

public static class RigUnit_FABRIKItemArrayMarshaler
{
    public static RigUnit_FABRIKItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FABRIKItemArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FABRIKItemArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FABRIKItemArray.NativeDataSize;
    }
}