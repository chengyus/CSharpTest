using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkCameraFrameData
{
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraFrameData:FieldOfView
    static readonly int FieldOfView_Offset;
    public float FieldOfView;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraFrameData:AspectRatio
    static readonly int AspectRatio_Offset;
    public float AspectRatio;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraFrameData:FocalLength
    static readonly int FocalLength_Offset;
    public float FocalLength;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraFrameData:Aperture
    static readonly int Aperture_Offset;
    public float Aperture;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraFrameData:FocusDistance
    static readonly int FocusDistance_Offset;
    public float FocusDistance;
    
    // EnumProperty /Script/LiveLinkInterface.LiveLinkCameraFrameData:ProjectionMode
    static readonly int ProjectionMode_Offset;
    public UnrealSharp.LiveLinkInterface.ELiveLinkCameraProjectionMode ProjectionMode;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkCameraFrameData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkCameraFrameData");
        
        FieldOfView_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FieldOfView");
        AspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AspectRatio");
        FocalLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocalLength");
        Aperture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Aperture");
        FocusDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusDistance");
        ProjectionMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProjectionMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkCameraFrameData(IntPtr InNativeStruct)
    {
        unsafe
        {
            FieldOfView = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FieldOfView_Offset), 0, null);
            AspectRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AspectRatio_Offset), 0, null);
            FocalLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocalLength_Offset), 0, null);
            Aperture = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Aperture_Offset), 0, null);
            FocusDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusDistance_Offset), 0, null);
            ProjectionMode = BlittableMarshaller<UnrealSharp.LiveLinkInterface.ELiveLinkCameraProjectionMode>.FromNative(IntPtr.Add(InNativeStruct, ProjectionMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FieldOfView_Offset), 0, null, FieldOfView);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AspectRatio_Offset), 0, null, AspectRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocalLength_Offset), 0, null, FocalLength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Aperture_Offset), 0, null, Aperture);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusDistance_Offset), 0, null, FocusDistance);
            BlittableMarshaller<UnrealSharp.LiveLinkInterface.ELiveLinkCameraProjectionMode>.ToNative(IntPtr.Add(Buffer, ProjectionMode_Offset), 0, null, ProjectionMode);
        }
    }
}

public static class LiveLinkCameraFrameDataMarshaler
{
    public static LiveLinkCameraFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkCameraFrameData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkCameraFrameData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkCameraFrameData.NativeDataSize;
    }
}