using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkCameraStaticData
{
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsFieldOfViewSupported
    static readonly int bIsFieldOfViewSupported_Offset;
    public bool IsFieldOfViewSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsAspectRatioSupported
    static readonly int bIsAspectRatioSupported_Offset;
    public bool IsAspectRatioSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsFocalLengthSupported
    static readonly int bIsFocalLengthSupported_Offset;
    public bool IsFocalLengthSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsProjectionModeSupported
    static readonly int bIsProjectionModeSupported_Offset;
    public bool IsProjectionModeSupported;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:FilmBackWidth
    static readonly int FilmBackWidth_Offset;
    public float FilmBackWidth;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:FilmBackHeight
    static readonly int FilmBackHeight_Offset;
    public float FilmBackHeight;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsApertureSupported
    static readonly int bIsApertureSupported_Offset;
    public bool IsApertureSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsFocusDistanceSupported
    static readonly int bIsFocusDistanceSupported_Offset;
    public bool IsFocusDistanceSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsDepthOfFieldSupported
    static readonly int bIsDepthOfFieldSupported_Offset;
    public bool IsDepthOfFieldSupported;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkCameraStaticData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkCameraStaticData");
        
        bIsFieldOfViewSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsFieldOfViewSupported");
        bIsAspectRatioSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsAspectRatioSupported");
        bIsFocalLengthSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsFocalLengthSupported");
        bIsProjectionModeSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsProjectionModeSupported");
        FilmBackWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmBackWidth");
        FilmBackHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmBackHeight");
        bIsApertureSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsApertureSupported");
        bIsFocusDistanceSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsFocusDistanceSupported");
        bIsDepthOfFieldSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsDepthOfFieldSupported");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkCameraStaticData(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsFieldOfViewSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsFieldOfViewSupported_Offset), 0, null);
            IsAspectRatioSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsAspectRatioSupported_Offset), 0, null);
            IsFocalLengthSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsFocalLengthSupported_Offset), 0, null);
            IsProjectionModeSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsProjectionModeSupported_Offset), 0, null);
            FilmBackWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmBackWidth_Offset), 0, null);
            FilmBackHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmBackHeight_Offset), 0, null);
            IsApertureSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsApertureSupported_Offset), 0, null);
            IsFocusDistanceSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsFocusDistanceSupported_Offset), 0, null);
            IsDepthOfFieldSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsDepthOfFieldSupported_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsFieldOfViewSupported_Offset), 0, null, IsFieldOfViewSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsAspectRatioSupported_Offset), 0, null, IsAspectRatioSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsFocalLengthSupported_Offset), 0, null, IsFocalLengthSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsProjectionModeSupported_Offset), 0, null, IsProjectionModeSupported);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmBackWidth_Offset), 0, null, FilmBackWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmBackHeight_Offset), 0, null, FilmBackHeight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsApertureSupported_Offset), 0, null, IsApertureSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsFocusDistanceSupported_Offset), 0, null, IsFocusDistanceSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsDepthOfFieldSupported_Offset), 0, null, IsDepthOfFieldSupported);
        }
    }
}

public static class LiveLinkCameraStaticDataMarshaler
{
    public static LiveLinkCameraStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkCameraStaticData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkCameraStaticData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkCameraStaticData.NativeDataSize;
    }
}