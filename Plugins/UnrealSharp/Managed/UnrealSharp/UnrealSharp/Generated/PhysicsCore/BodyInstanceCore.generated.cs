using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UStruct]
public partial struct BodyInstanceCore
{
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bSimulatePhysics
    static readonly int bSimulatePhysics_Offset;
    static readonly IntPtr bSimulatePhysics_NativeProperty;
    public bool SimulatePhysics;
    
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bEnableGravity
    static readonly int bEnableGravity_Offset;
    static readonly IntPtr bEnableGravity_NativeProperty;
    public bool EnableGravity;
    
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bUpdateKinematicFromSimulation
    static readonly int bUpdateKinematicFromSimulation_Offset;
    static readonly IntPtr bUpdateKinematicFromSimulation_NativeProperty;
    public bool UpdateKinematicFromSimulation;
    
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bAutoWeld
    static readonly int bAutoWeld_Offset;
    static readonly IntPtr bAutoWeld_NativeProperty;
    public bool AutoWeld;
    
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bStartAwake
    static readonly int bStartAwake_Offset;
    static readonly IntPtr bStartAwake_NativeProperty;
    public bool StartAwake;
    
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bGenerateWakeEvents
    static readonly int bGenerateWakeEvents_Offset;
    static readonly IntPtr bGenerateWakeEvents_NativeProperty;
    public bool GenerateWakeEvents;
    
    // BoolProperty /Script/PhysicsCore.BodyInstanceCore:bUpdateMassWhenScaleChanges
    static readonly int bUpdateMassWhenScaleChanges_Offset;
    static readonly IntPtr bUpdateMassWhenScaleChanges_NativeProperty;
    public bool UpdateMassWhenScaleChanges;
    
    
    public static readonly int NativeDataSize;
    static BodyInstanceCore()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BodyInstanceCore");
        
        bSimulatePhysics_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSimulatePhysics");
        bSimulatePhysics_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSimulatePhysics");
        bEnableGravity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableGravity");
        bEnableGravity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableGravity");
        bUpdateKinematicFromSimulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUpdateKinematicFromSimulation");
        bUpdateKinematicFromSimulation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUpdateKinematicFromSimulation");
        bAutoWeld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoWeld");
        bAutoWeld_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAutoWeld");
        bStartAwake_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStartAwake");
        bStartAwake_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bStartAwake");
        bGenerateWakeEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateWakeEvents");
        bGenerateWakeEvents_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateWakeEvents");
        bUpdateMassWhenScaleChanges_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUpdateMassWhenScaleChanges");
        bUpdateMassWhenScaleChanges_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUpdateMassWhenScaleChanges");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BodyInstanceCore(IntPtr InNativeStruct)
    {
        unsafe
        {
            SimulatePhysics = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSimulatePhysics_NativeProperty, bSimulatePhysics_Offset);
            EnableGravity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableGravity_NativeProperty, bEnableGravity_Offset);
            UpdateKinematicFromSimulation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUpdateKinematicFromSimulation_NativeProperty, bUpdateKinematicFromSimulation_Offset);
            AutoWeld = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAutoWeld_NativeProperty, bAutoWeld_Offset);
            StartAwake = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bStartAwake_NativeProperty, bStartAwake_Offset);
            GenerateWakeEvents = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateWakeEvents_NativeProperty, bGenerateWakeEvents_Offset);
            UpdateMassWhenScaleChanges = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUpdateMassWhenScaleChanges_NativeProperty, bUpdateMassWhenScaleChanges_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSimulatePhysics_NativeProperty, bSimulatePhysics_Offset, SimulatePhysics);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableGravity_NativeProperty, bEnableGravity_Offset, EnableGravity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUpdateKinematicFromSimulation_NativeProperty, bUpdateKinematicFromSimulation_Offset, UpdateKinematicFromSimulation);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAutoWeld_NativeProperty, bAutoWeld_Offset, AutoWeld);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bStartAwake_NativeProperty, bStartAwake_Offset, StartAwake);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateWakeEvents_NativeProperty, bGenerateWakeEvents_Offset, GenerateWakeEvents);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUpdateMassWhenScaleChanges_NativeProperty, bUpdateMassWhenScaleChanges_Offset, UpdateMassWhenScaleChanges);
        }
    }
}

public static class BodyInstanceCoreMarshaler
{
    public static BodyInstanceCore FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BodyInstanceCore(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BodyInstanceCore obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BodyInstanceCore.NativeDataSize;
    }
}