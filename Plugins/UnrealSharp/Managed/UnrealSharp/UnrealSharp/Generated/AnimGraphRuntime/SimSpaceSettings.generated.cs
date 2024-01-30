using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct SimSpaceSettings
{
    // FloatProperty /Script/AnimGraphRuntime.SimSpaceSettings:WorldAlpha
    static readonly int WorldAlpha_Offset;
    public float WorldAlpha;
    
    // FloatProperty /Script/AnimGraphRuntime.SimSpaceSettings:VelocityScaleZ
    static readonly int VelocityScaleZ_Offset;
    public float VelocityScaleZ;
    
    // FloatProperty /Script/AnimGraphRuntime.SimSpaceSettings:MaxLinearVelocity
    static readonly int MaxLinearVelocity_Offset;
    public float MaxLinearVelocity;
    
    // FloatProperty /Script/AnimGraphRuntime.SimSpaceSettings:MaxAngularVelocity
    static readonly int MaxAngularVelocity_Offset;
    public float MaxAngularVelocity;
    
    // FloatProperty /Script/AnimGraphRuntime.SimSpaceSettings:MaxLinearAcceleration
    static readonly int MaxLinearAcceleration_Offset;
    public float MaxLinearAcceleration;
    
    // FloatProperty /Script/AnimGraphRuntime.SimSpaceSettings:MaxAngularAcceleration
    static readonly int MaxAngularAcceleration_Offset;
    public float MaxAngularAcceleration;
    
    // StructProperty /Script/AnimGraphRuntime.SimSpaceSettings:ExternalLinearDragV
    static readonly int ExternalLinearDragV_Offset;
    public System.DoubleNumerics.Vector3 ExternalLinearDragV;
    
    // StructProperty /Script/AnimGraphRuntime.SimSpaceSettings:ExternalLinearVelocity
    static readonly int ExternalLinearVelocity_Offset;
    public System.DoubleNumerics.Vector3 ExternalLinearVelocity;
    
    // StructProperty /Script/AnimGraphRuntime.SimSpaceSettings:ExternalAngularVelocity
    static readonly int ExternalAngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 ExternalAngularVelocity;
    
    
    public static readonly int NativeDataSize;
    static SimSpaceSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SimSpaceSettings");
        
        WorldAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldAlpha");
        VelocityScaleZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VelocityScaleZ");
        MaxLinearVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxLinearVelocity");
        MaxAngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAngularVelocity");
        MaxLinearAcceleration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxLinearAcceleration");
        MaxAngularAcceleration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAngularAcceleration");
        ExternalLinearDragV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalLinearDragV");
        ExternalLinearVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalLinearVelocity");
        ExternalAngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalAngularVelocity");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SimSpaceSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            WorldAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WorldAlpha_Offset), 0, null);
            VelocityScaleZ = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VelocityScaleZ_Offset), 0, null);
            MaxLinearVelocity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxLinearVelocity_Offset), 0, null);
            MaxAngularVelocity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxAngularVelocity_Offset), 0, null);
            MaxLinearAcceleration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxLinearAcceleration_Offset), 0, null);
            MaxAngularAcceleration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxAngularAcceleration_Offset), 0, null);
            ExternalLinearDragV = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ExternalLinearDragV_Offset), 0, null);
            ExternalLinearVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ExternalLinearVelocity_Offset), 0, null);
            ExternalAngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ExternalAngularVelocity_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WorldAlpha_Offset), 0, null, WorldAlpha);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VelocityScaleZ_Offset), 0, null, VelocityScaleZ);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxLinearVelocity_Offset), 0, null, MaxLinearVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxAngularVelocity_Offset), 0, null, MaxAngularVelocity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxLinearAcceleration_Offset), 0, null, MaxLinearAcceleration);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxAngularAcceleration_Offset), 0, null, MaxAngularAcceleration);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ExternalLinearDragV_Offset), 0, null, ExternalLinearDragV);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ExternalLinearVelocity_Offset), 0, null, ExternalLinearVelocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ExternalAngularVelocity_Offset), 0, null, ExternalAngularVelocity);
        }
    }
}

public static class SimSpaceSettingsMarshaler
{
    public static SimSpaceSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SimSpaceSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SimSpaceSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SimSpaceSettings.NativeDataSize;
    }
}