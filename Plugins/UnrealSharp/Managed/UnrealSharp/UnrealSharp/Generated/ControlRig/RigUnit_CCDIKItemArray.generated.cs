using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CCDIKItemArray
{
    // StructProperty /Script/ControlRig.RigUnit_CCDIKItemArray:EffectorTransform
    static readonly int EffectorTransform_Offset;
    public UnrealSharp.Transform EffectorTransform;
    
    // FloatProperty /Script/ControlRig.RigUnit_CCDIKItemArray:Precision
    static readonly int Precision_Offset;
    public float Precision;
    
    // FloatProperty /Script/ControlRig.RigUnit_CCDIKItemArray:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // IntProperty /Script/ControlRig.RigUnit_CCDIKItemArray:MaxIterations
    static readonly int MaxIterations_Offset;
    public int MaxIterations;
    
    // BoolProperty /Script/ControlRig.RigUnit_CCDIKItemArray:bStartFromTail
    static readonly int bStartFromTail_Offset;
    public bool StartFromTail;
    
    // FloatProperty /Script/ControlRig.RigUnit_CCDIKItemArray:BaseRotationLimit
    static readonly int BaseRotationLimit_Offset;
    public float BaseRotationLimit;
    
    // BoolProperty /Script/ControlRig.RigUnit_CCDIKItemArray:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CCDIKItemArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CCDIKItemArray");
        
        EffectorTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorTransform");
        Precision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Precision");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        MaxIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxIterations");
        bStartFromTail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStartFromTail");
        BaseRotationLimit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseRotationLimit");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CCDIKItemArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            EffectorTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, EffectorTransform_Offset), 0, null);
            Precision = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Precision_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            MaxIterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxIterations_Offset), 0, null);
            StartFromTail = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bStartFromTail_Offset), 0, null);
            BaseRotationLimit = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BaseRotationLimit_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
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
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxIterations_Offset), 0, null, MaxIterations);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bStartFromTail_Offset), 0, null, StartFromTail);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BaseRotationLimit_Offset), 0, null, BaseRotationLimit);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_CCDIKItemArrayMarshaler
{
    public static RigUnit_CCDIKItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CCDIKItemArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CCDIKItemArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CCDIKItemArray.NativeDataSize;
    }
}