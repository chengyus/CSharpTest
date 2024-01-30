using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_AnimDynamics
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:LinearDampingOverride
    static readonly int LinearDampingOverride_Offset;
    public float LinearDampingOverride;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:AngularDampingOverride
    static readonly int AngularDampingOverride_Offset;
    public float AngularDampingOverride;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:GravityScale
    static readonly int GravityScale_Offset;
    public float GravityScale;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:GravityOverride
    static readonly int GravityOverride_Offset;
    public System.DoubleNumerics.Vector3 GravityOverride;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:LinearSpringConstant
    static readonly int LinearSpringConstant_Offset;
    public float LinearSpringConstant;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:AngularSpringConstant
    static readonly int AngularSpringConstant_Offset;
    public float AngularSpringConstant;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:AngularBiasOverride
    static readonly int AngularBiasOverride_Offset;
    public float AngularBiasOverride;
    
    // EnumProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:SimulationSpace
    static readonly int SimulationSpace_Offset;
    public UnrealSharp.AnimGraphRuntime.AnimPhysSimSpaceType SimulationSpace;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_AnimDynamics:bUseGravityOverride
    static readonly int bUseGravityOverride_Offset;
    static readonly IntPtr bUseGravityOverride_NativeProperty;
    public bool UseGravityOverride;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_AnimDynamics()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_AnimDynamics");
        
        LinearDampingOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinearDampingOverride");
        AngularDampingOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularDampingOverride");
        GravityScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GravityScale");
        GravityOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GravityOverride");
        LinearSpringConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinearSpringConstant");
        AngularSpringConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularSpringConstant");
        AngularBiasOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularBiasOverride");
        SimulationSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SimulationSpace");
        bUseGravityOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseGravityOverride");
        bUseGravityOverride_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseGravityOverride");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_AnimDynamics(IntPtr InNativeStruct)
    {
        unsafe
        {
            LinearDampingOverride = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LinearDampingOverride_Offset), 0, null);
            AngularDampingOverride = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AngularDampingOverride_Offset), 0, null);
            GravityScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GravityScale_Offset), 0, null);
            GravityOverride = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, GravityOverride_Offset), 0, null);
            LinearSpringConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LinearSpringConstant_Offset), 0, null);
            AngularSpringConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AngularSpringConstant_Offset), 0, null);
            AngularBiasOverride = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AngularBiasOverride_Offset), 0, null);
            SimulationSpace = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.AnimPhysSimSpaceType>.FromNative(IntPtr.Add(InNativeStruct, SimulationSpace_Offset), 0, null);
            UseGravityOverride = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseGravityOverride_NativeProperty, bUseGravityOverride_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LinearDampingOverride_Offset), 0, null, LinearDampingOverride);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AngularDampingOverride_Offset), 0, null, AngularDampingOverride);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GravityScale_Offset), 0, null, GravityScale);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, GravityOverride_Offset), 0, null, GravityOverride);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LinearSpringConstant_Offset), 0, null, LinearSpringConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AngularSpringConstant_Offset), 0, null, AngularSpringConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AngularBiasOverride_Offset), 0, null, AngularBiasOverride);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.AnimPhysSimSpaceType>.ToNative(IntPtr.Add(Buffer, SimulationSpace_Offset), 0, null, SimulationSpace);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseGravityOverride_NativeProperty, bUseGravityOverride_Offset, UseGravityOverride);
        }
    }
}

public static class AnimNode_AnimDynamicsMarshaler
{
    public static AnimNode_AnimDynamics FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_AnimDynamics(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_AnimDynamics obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_AnimDynamics.NativeDataSize;
    }
}