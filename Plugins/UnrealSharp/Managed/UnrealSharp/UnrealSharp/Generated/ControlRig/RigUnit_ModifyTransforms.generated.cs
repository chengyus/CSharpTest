using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ModifyTransforms
{
    // FloatProperty /Script/ControlRig.RigUnit_ModifyTransforms:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // FloatProperty /Script/ControlRig.RigUnit_ModifyTransforms:WeightMinimum
    static readonly int WeightMinimum_Offset;
    public float WeightMinimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_ModifyTransforms:WeightMaximum
    static readonly int WeightMaximum_Offset;
    public float WeightMaximum;
    
    // EnumProperty /Script/ControlRig.RigUnit_ModifyTransforms:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.ControlRig.EControlRigModifyBoneMode Mode;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ModifyTransforms()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ModifyTransforms");
        
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        WeightMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeightMinimum");
        WeightMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeightMaximum");
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ModifyTransforms(IntPtr InNativeStruct)
    {
        unsafe
        {
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            WeightMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WeightMinimum_Offset), 0, null);
            WeightMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WeightMaximum_Offset), 0, null);
            Mode = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigModifyBoneMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WeightMinimum_Offset), 0, null, WeightMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WeightMaximum_Offset), 0, null, WeightMaximum);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigModifyBoneMode>.ToNative(IntPtr.Add(Buffer, Mode_Offset), 0, null, Mode);
        }
    }
}

public static class RigUnit_ModifyTransformsMarshaler
{
    public static RigUnit_ModifyTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ModifyTransforms(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ModifyTransforms obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ModifyTransforms.NativeDataSize;
    }
}