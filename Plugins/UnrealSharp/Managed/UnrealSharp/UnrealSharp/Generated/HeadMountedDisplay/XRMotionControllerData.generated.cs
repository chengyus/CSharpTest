using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UStruct]
public partial struct XRMotionControllerData
{
    // BoolProperty /Script/HeadMountedDisplay.XRMotionControllerData:bValid
    static readonly int bValid_Offset;
    public bool Valid;
    
    // NameProperty /Script/HeadMountedDisplay.XRMotionControllerData:DeviceName
    static readonly int DeviceName_Offset;
    public Name DeviceName;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:ApplicationInstanceID
    static readonly int ApplicationInstanceID_Offset;
    public UnrealSharp.CoreUObject.Guid ApplicationInstanceID;
    
    // EnumProperty /Script/HeadMountedDisplay.XRMotionControllerData:DeviceVisualType
    static readonly int DeviceVisualType_Offset;
    public UnrealSharp.HeadMountedDisplay.EXRVisualType DeviceVisualType;
    
    // EnumProperty /Script/HeadMountedDisplay.XRMotionControllerData:HandIndex
    static readonly int HandIndex_Offset;
    public UnrealSharp.InputCore.EControllerHand HandIndex;
    
    // EnumProperty /Script/HeadMountedDisplay.XRMotionControllerData:TrackingStatus
    static readonly int TrackingStatus_Offset;
    public UnrealSharp.HeadMountedDisplay.ETrackingStatus TrackingStatus;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:GripPosition
    static readonly int GripPosition_Offset;
    public System.DoubleNumerics.Vector3 GripPosition;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:GripRotation
    static readonly int GripRotation_Offset;
    public System.DoubleNumerics.Quaternion GripRotation;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:AimPosition
    static readonly int AimPosition_Offset;
    public System.DoubleNumerics.Vector3 AimPosition;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:AimRotation
    static readonly int AimRotation_Offset;
    public System.DoubleNumerics.Quaternion AimRotation;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:PalmPosition
    static readonly int PalmPosition_Offset;
    public System.DoubleNumerics.Vector3 PalmPosition;
    
    // StructProperty /Script/HeadMountedDisplay.XRMotionControllerData:PalmRotation
    static readonly int PalmRotation_Offset;
    public System.DoubleNumerics.Quaternion PalmRotation;
    
    // BoolProperty /Script/HeadMountedDisplay.XRMotionControllerData:bIsGrasped
    static readonly int bIsGrasped_Offset;
    public bool IsGrasped;
    
    
    public static readonly int NativeDataSize;
    static XRMotionControllerData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("XRMotionControllerData");
        
        bValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bValid");
        DeviceName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeviceName");
        ApplicationInstanceID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApplicationInstanceID");
        DeviceVisualType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeviceVisualType");
        HandIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandIndex");
        TrackingStatus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TrackingStatus");
        GripPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GripPosition");
        GripRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GripRotation");
        AimPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AimPosition");
        AimRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AimRotation");
        PalmPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PalmPosition");
        PalmRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PalmRotation");
        bIsGrasped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsGrasped");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public XRMotionControllerData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bValid_Offset), 0, null);
            DeviceName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, DeviceName_Offset), 0, null);
            ApplicationInstanceID = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, ApplicationInstanceID_Offset), 0, null);
            DeviceVisualType = BlittableMarshaller<UnrealSharp.HeadMountedDisplay.EXRVisualType>.FromNative(IntPtr.Add(InNativeStruct, DeviceVisualType_Offset), 0, null);
            HandIndex = BlittableMarshaller<UnrealSharp.InputCore.EControllerHand>.FromNative(IntPtr.Add(InNativeStruct, HandIndex_Offset), 0, null);
            TrackingStatus = BlittableMarshaller<UnrealSharp.HeadMountedDisplay.ETrackingStatus>.FromNative(IntPtr.Add(InNativeStruct, TrackingStatus_Offset), 0, null);
            GripPosition = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, GripPosition_Offset), 0, null);
            GripRotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, GripRotation_Offset), 0, null);
            AimPosition = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AimPosition_Offset), 0, null);
            AimRotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, AimRotation_Offset), 0, null);
            PalmPosition = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PalmPosition_Offset), 0, null);
            PalmRotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, PalmRotation_Offset), 0, null);
            IsGrasped = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsGrasped_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bValid_Offset), 0, null, Valid);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, DeviceName_Offset), 0, null, DeviceName);
            UnrealSharp.CoreUObject.GuidMarshaler.ToNative(IntPtr.Add(Buffer, ApplicationInstanceID_Offset), 0, null, ApplicationInstanceID);
            BlittableMarshaller<UnrealSharp.HeadMountedDisplay.EXRVisualType>.ToNative(IntPtr.Add(Buffer, DeviceVisualType_Offset), 0, null, DeviceVisualType);
            BlittableMarshaller<UnrealSharp.InputCore.EControllerHand>.ToNative(IntPtr.Add(Buffer, HandIndex_Offset), 0, null, HandIndex);
            BlittableMarshaller<UnrealSharp.HeadMountedDisplay.ETrackingStatus>.ToNative(IntPtr.Add(Buffer, TrackingStatus_Offset), 0, null, TrackingStatus);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, GripPosition_Offset), 0, null, GripPosition);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, GripRotation_Offset), 0, null, GripRotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AimPosition_Offset), 0, null, AimPosition);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, AimRotation_Offset), 0, null, AimRotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PalmPosition_Offset), 0, null, PalmPosition);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, PalmRotation_Offset), 0, null, PalmRotation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsGrasped_Offset), 0, null, IsGrasped);
        }
    }
}

public static class XRMotionControllerDataMarshaler
{
    public static XRMotionControllerData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new XRMotionControllerData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, XRMotionControllerData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return XRMotionControllerData.NativeDataSize;
    }
}