using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SphericalPoseReader
{
    // FloatProperty /Script/ControlRig.RigUnit_SphericalPoseReader:OutputParam
    static readonly int OutputParam_Offset;
    public float OutputParam;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:DriverItem
    static readonly int DriverItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey DriverItem;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:DriverAxis
    static readonly int DriverAxis_Offset;
    public System.DoubleNumerics.Vector3 DriverAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:RotationOffset
    static readonly int RotationOffset_Offset;
    public System.DoubleNumerics.Vector3 RotationOffset;
    
    // FloatProperty /Script/ControlRig.RigUnit_SphericalPoseReader:ActiveRegionSize
    static readonly int ActiveRegionSize_Offset;
    public float ActiveRegionSize;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:ActiveRegionScaleFactors
    static readonly int ActiveRegionScaleFactors_Offset;
    public UnrealSharp.ControlRig.RegionScaleFactors ActiveRegionScaleFactors;
    
    // FloatProperty /Script/ControlRig.RigUnit_SphericalPoseReader:FalloffSize
    static readonly int FalloffSize_Offset;
    public float FalloffSize;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:FalloffRegionScaleFactors
    static readonly int FalloffRegionScaleFactors_Offset;
    public UnrealSharp.ControlRig.RegionScaleFactors FalloffRegionScaleFactors;
    
    // BoolProperty /Script/ControlRig.RigUnit_SphericalPoseReader:FlipWidthScaling
    static readonly int FlipWidthScaling_Offset;
    public bool FlipWidthScaling;
    
    // BoolProperty /Script/ControlRig.RigUnit_SphericalPoseReader:FlipHeightScaling
    static readonly int FlipHeightScaling_Offset;
    public bool FlipHeightScaling;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:OptionalParentItem
    static readonly int OptionalParentItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey OptionalParentItem;
    
    // StructProperty /Script/ControlRig.RigUnit_SphericalPoseReader:Debug
    static readonly int Debug_Offset;
    public UnrealSharp.ControlRig.SphericalPoseReaderDebugSettings Debug;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SphericalPoseReader()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SphericalPoseReader");
        
        OutputParam_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputParam");
        DriverItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DriverItem");
        DriverAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DriverAxis");
        RotationOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOffset");
        ActiveRegionSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveRegionSize");
        ActiveRegionScaleFactors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveRegionScaleFactors");
        FalloffSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FalloffSize");
        FalloffRegionScaleFactors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FalloffRegionScaleFactors");
        FlipWidthScaling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FlipWidthScaling");
        FlipHeightScaling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FlipHeightScaling");
        OptionalParentItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OptionalParentItem");
        Debug_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Debug");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SphericalPoseReader(IntPtr InNativeStruct)
    {
        unsafe
        {
            OutputParam = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OutputParam_Offset), 0, null);
            DriverItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, DriverItem_Offset), 0, null);
            DriverAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, DriverAxis_Offset), 0, null);
            RotationOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, RotationOffset_Offset), 0, null);
            ActiveRegionSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ActiveRegionSize_Offset), 0, null);
            ActiveRegionScaleFactors = BlittableMarshaller<UnrealSharp.ControlRig.RegionScaleFactors>.FromNative(IntPtr.Add(InNativeStruct, ActiveRegionScaleFactors_Offset), 0, null);
            FalloffSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FalloffSize_Offset), 0, null);
            FalloffRegionScaleFactors = BlittableMarshaller<UnrealSharp.ControlRig.RegionScaleFactors>.FromNative(IntPtr.Add(InNativeStruct, FalloffRegionScaleFactors_Offset), 0, null);
            FlipWidthScaling = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, FlipWidthScaling_Offset), 0, null);
            FlipHeightScaling = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, FlipHeightScaling_Offset), 0, null);
            OptionalParentItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, OptionalParentItem_Offset), 0, null);
            Debug = UnrealSharp.ControlRig.SphericalPoseReaderDebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Debug_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OutputParam_Offset), 0, null, OutputParam);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, DriverItem_Offset), 0, null, DriverItem);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, DriverAxis_Offset), 0, null, DriverAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, RotationOffset_Offset), 0, null, RotationOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ActiveRegionSize_Offset), 0, null, ActiveRegionSize);
            BlittableMarshaller<UnrealSharp.ControlRig.RegionScaleFactors>.ToNative(IntPtr.Add(Buffer, ActiveRegionScaleFactors_Offset), 0, null, ActiveRegionScaleFactors);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FalloffSize_Offset), 0, null, FalloffSize);
            BlittableMarshaller<UnrealSharp.ControlRig.RegionScaleFactors>.ToNative(IntPtr.Add(Buffer, FalloffRegionScaleFactors_Offset), 0, null, FalloffRegionScaleFactors);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, FlipWidthScaling_Offset), 0, null, FlipWidthScaling);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, FlipHeightScaling_Offset), 0, null, FlipHeightScaling);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, OptionalParentItem_Offset), 0, null, OptionalParentItem);
            UnrealSharp.ControlRig.SphericalPoseReaderDebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Debug_Offset), 0, null, Debug);
        }
    }
}

public static class RigUnit_SphericalPoseReaderMarshaler
{
    public static RigUnit_SphericalPoseReader FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SphericalPoseReader(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SphericalPoseReader obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SphericalPoseReader.NativeDataSize;
    }
}