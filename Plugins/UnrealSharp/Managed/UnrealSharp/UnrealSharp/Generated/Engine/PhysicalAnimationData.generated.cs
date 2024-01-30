using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PhysicalAnimationData
{
    // BoolProperty /Script/Engine.PhysicalAnimationData:bIsLocalSimulation
    static readonly int bIsLocalSimulation_Offset;
    static readonly IntPtr bIsLocalSimulation_NativeProperty;
    public bool IsLocalSimulation;
    
    // FloatProperty /Script/Engine.PhysicalAnimationData:OrientationStrength
    static readonly int OrientationStrength_Offset;
    public float OrientationStrength;
    
    // FloatProperty /Script/Engine.PhysicalAnimationData:AngularVelocityStrength
    static readonly int AngularVelocityStrength_Offset;
    public float AngularVelocityStrength;
    
    // FloatProperty /Script/Engine.PhysicalAnimationData:PositionStrength
    static readonly int PositionStrength_Offset;
    public float PositionStrength;
    
    // FloatProperty /Script/Engine.PhysicalAnimationData:VelocityStrength
    static readonly int VelocityStrength_Offset;
    public float VelocityStrength;
    
    // FloatProperty /Script/Engine.PhysicalAnimationData:MaxLinearForce
    static readonly int MaxLinearForce_Offset;
    public float MaxLinearForce;
    
    // FloatProperty /Script/Engine.PhysicalAnimationData:MaxAngularForce
    static readonly int MaxAngularForce_Offset;
    public float MaxAngularForce;
    
    
    public static readonly int NativeDataSize;
    static PhysicalAnimationData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PhysicalAnimationData");
        
        bIsLocalSimulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsLocalSimulation");
        bIsLocalSimulation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsLocalSimulation");
        OrientationStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrientationStrength");
        AngularVelocityStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularVelocityStrength");
        PositionStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionStrength");
        VelocityStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VelocityStrength");
        MaxLinearForce_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxLinearForce");
        MaxAngularForce_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAngularForce");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PhysicalAnimationData(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsLocalSimulation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsLocalSimulation_NativeProperty, bIsLocalSimulation_Offset);
            OrientationStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OrientationStrength_Offset), 0, null);
            AngularVelocityStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AngularVelocityStrength_Offset), 0, null);
            PositionStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PositionStrength_Offset), 0, null);
            VelocityStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VelocityStrength_Offset), 0, null);
            MaxLinearForce = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxLinearForce_Offset), 0, null);
            MaxAngularForce = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxAngularForce_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsLocalSimulation_NativeProperty, bIsLocalSimulation_Offset, IsLocalSimulation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OrientationStrength_Offset), 0, null, OrientationStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AngularVelocityStrength_Offset), 0, null, AngularVelocityStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PositionStrength_Offset), 0, null, PositionStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VelocityStrength_Offset), 0, null, VelocityStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxLinearForce_Offset), 0, null, MaxLinearForce);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxAngularForce_Offset), 0, null, MaxAngularForce);
        }
    }
}

public static class PhysicalAnimationDataMarshaler
{
    public static PhysicalAnimationData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PhysicalAnimationData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PhysicalAnimationData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PhysicalAnimationData.NativeDataSize;
    }
}