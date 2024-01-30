using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UStruct]
public partial struct XRGestureConfig
{
    // BoolProperty /Script/HeadMountedDisplay.XRGestureConfig:bTap
    static readonly int bTap_Offset;
    public bool Tap;
    
    // BoolProperty /Script/HeadMountedDisplay.XRGestureConfig:bHold
    static readonly int bHold_Offset;
    public bool Hold;
    
    // EnumProperty /Script/HeadMountedDisplay.XRGestureConfig:AxisGesture
    static readonly int AxisGesture_Offset;
    public UnrealSharp.HeadMountedDisplay.ESpatialInputGestureAxis AxisGesture;
    
    // BoolProperty /Script/HeadMountedDisplay.XRGestureConfig:bNavigationAxisX
    static readonly int bNavigationAxisX_Offset;
    public bool NavigationAxisX;
    
    // BoolProperty /Script/HeadMountedDisplay.XRGestureConfig:bNavigationAxisY
    static readonly int bNavigationAxisY_Offset;
    public bool NavigationAxisY;
    
    // BoolProperty /Script/HeadMountedDisplay.XRGestureConfig:bNavigationAxisZ
    static readonly int bNavigationAxisZ_Offset;
    public bool NavigationAxisZ;
    
    
    public static readonly int NativeDataSize;
    static XRGestureConfig()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("XRGestureConfig");
        
        bTap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTap");
        bHold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHold");
        AxisGesture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AxisGesture");
        bNavigationAxisX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNavigationAxisX");
        bNavigationAxisY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNavigationAxisY");
        bNavigationAxisZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNavigationAxisZ");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public XRGestureConfig(IntPtr InNativeStruct)
    {
        unsafe
        {
            Tap = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTap_Offset), 0, null);
            Hold = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHold_Offset), 0, null);
            AxisGesture = BlittableMarshaller<UnrealSharp.HeadMountedDisplay.ESpatialInputGestureAxis>.FromNative(IntPtr.Add(InNativeStruct, AxisGesture_Offset), 0, null);
            NavigationAxisX = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNavigationAxisX_Offset), 0, null);
            NavigationAxisY = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNavigationAxisY_Offset), 0, null);
            NavigationAxisZ = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNavigationAxisZ_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTap_Offset), 0, null, Tap);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHold_Offset), 0, null, Hold);
            BlittableMarshaller<UnrealSharp.HeadMountedDisplay.ESpatialInputGestureAxis>.ToNative(IntPtr.Add(Buffer, AxisGesture_Offset), 0, null, AxisGesture);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNavigationAxisX_Offset), 0, null, NavigationAxisX);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNavigationAxisY_Offset), 0, null, NavigationAxisY);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNavigationAxisZ_Offset), 0, null, NavigationAxisZ);
        }
    }
}

public static class XRGestureConfigMarshaler
{
    public static XRGestureConfig FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new XRGestureConfig(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, XRGestureConfig obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return XRGestureConfig.NativeDataSize;
    }
}