using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UStruct]
public partial struct XRHMDData
{
    // BoolProperty /Script/HeadMountedDisplay.XRHMDData:bValid
    static readonly int bValid_Offset;
    public bool Valid;
    
    // NameProperty /Script/HeadMountedDisplay.XRHMDData:DeviceName
    static readonly int DeviceName_Offset;
    public Name DeviceName;
    
    // StructProperty /Script/HeadMountedDisplay.XRHMDData:ApplicationInstanceID
    static readonly int ApplicationInstanceID_Offset;
    public UnrealSharp.CoreUObject.Guid ApplicationInstanceID;
    
    // EnumProperty /Script/HeadMountedDisplay.XRHMDData:TrackingStatus
    static readonly int TrackingStatus_Offset;
    public UnrealSharp.HeadMountedDisplay.ETrackingStatus TrackingStatus;
    
    // StructProperty /Script/HeadMountedDisplay.XRHMDData:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // StructProperty /Script/HeadMountedDisplay.XRHMDData:Rotation
    static readonly int Rotation_Offset;
    public System.DoubleNumerics.Quaternion Rotation;
    
    
    public static readonly int NativeDataSize;
    static XRHMDData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("XRHMDData");
        
        bValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bValid");
        DeviceName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeviceName");
        ApplicationInstanceID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApplicationInstanceID");
        TrackingStatus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TrackingStatus");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public XRHMDData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bValid_Offset), 0, null);
            DeviceName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, DeviceName_Offset), 0, null);
            ApplicationInstanceID = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, ApplicationInstanceID_Offset), 0, null);
            TrackingStatus = BlittableMarshaller<UnrealSharp.HeadMountedDisplay.ETrackingStatus>.FromNative(IntPtr.Add(InNativeStruct, TrackingStatus_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            Rotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
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
            BlittableMarshaller<UnrealSharp.HeadMountedDisplay.ETrackingStatus>.ToNative(IntPtr.Add(Buffer, TrackingStatus_Offset), 0, null, TrackingStatus);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
        }
    }
}

public static class XRHMDDataMarshaler
{
    public static XRHMDData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new XRHMDData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, XRHMDData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return XRHMDData.NativeDataSize;
    }
}