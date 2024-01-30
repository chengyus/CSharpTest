using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UStruct]
public partial struct CameraAnimationParams
{
    // FloatProperty /Script/GameplayCameras.CameraAnimationParams:PlayRate
    static readonly int PlayRate_Offset;
    public float PlayRate;
    
    // FloatProperty /Script/GameplayCameras.CameraAnimationParams:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // EnumProperty /Script/GameplayCameras.CameraAnimationParams:EaseInType
    static readonly int EaseInType_Offset;
    public UnrealSharp.GameplayCameras.ECameraAnimationEasingType EaseInType;
    
    // FloatProperty /Script/GameplayCameras.CameraAnimationParams:EaseInDuration
    static readonly int EaseInDuration_Offset;
    public float EaseInDuration;
    
    // EnumProperty /Script/GameplayCameras.CameraAnimationParams:EaseOutType
    static readonly int EaseOutType_Offset;
    public UnrealSharp.GameplayCameras.ECameraAnimationEasingType EaseOutType;
    
    // FloatProperty /Script/GameplayCameras.CameraAnimationParams:EaseOutDuration
    static readonly int EaseOutDuration_Offset;
    public float EaseOutDuration;
    
    // BoolProperty /Script/GameplayCameras.CameraAnimationParams:bLoop
    static readonly int bLoop_Offset;
    public bool Loop;
    
    // IntProperty /Script/GameplayCameras.CameraAnimationParams:StartOffset
    static readonly int StartOffset_Offset;
    public int StartOffset;
    
    // BoolProperty /Script/GameplayCameras.CameraAnimationParams:bRandomStartTime
    static readonly int bRandomStartTime_Offset;
    public bool RandomStartTime;
    
    // FloatProperty /Script/GameplayCameras.CameraAnimationParams:DurationOverride
    static readonly int DurationOverride_Offset;
    public float DurationOverride;
    
    // EnumProperty /Script/GameplayCameras.CameraAnimationParams:PlaySpace
    static readonly int PlaySpace_Offset;
    public UnrealSharp.GameplayCameras.ECameraAnimationPlaySpace PlaySpace;
    
    // StructProperty /Script/GameplayCameras.CameraAnimationParams:UserPlaySpaceRot
    static readonly int UserPlaySpaceRot_Offset;
    public UnrealSharp.Rotator UserPlaySpaceRot;
    
    
    public static readonly int NativeDataSize;
    static CameraAnimationParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraAnimationParams");
        
        PlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayRate");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        EaseInType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EaseInType");
        EaseInDuration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EaseInDuration");
        EaseOutType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EaseOutType");
        EaseOutDuration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EaseOutDuration");
        bLoop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLoop");
        StartOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartOffset");
        bRandomStartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRandomStartTime");
        DurationOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DurationOverride");
        PlaySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaySpace");
        UserPlaySpaceRot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserPlaySpaceRot");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraAnimationParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            PlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlayRate_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            EaseInType = BlittableMarshaller<UnrealSharp.GameplayCameras.ECameraAnimationEasingType>.FromNative(IntPtr.Add(InNativeStruct, EaseInType_Offset), 0, null);
            EaseInDuration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EaseInDuration_Offset), 0, null);
            EaseOutType = BlittableMarshaller<UnrealSharp.GameplayCameras.ECameraAnimationEasingType>.FromNative(IntPtr.Add(InNativeStruct, EaseOutType_Offset), 0, null);
            EaseOutDuration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EaseOutDuration_Offset), 0, null);
            Loop = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLoop_Offset), 0, null);
            StartOffset = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, StartOffset_Offset), 0, null);
            RandomStartTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRandomStartTime_Offset), 0, null);
            DurationOverride = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DurationOverride_Offset), 0, null);
            PlaySpace = BlittableMarshaller<UnrealSharp.GameplayCameras.ECameraAnimationPlaySpace>.FromNative(IntPtr.Add(InNativeStruct, PlaySpace_Offset), 0, null);
            UserPlaySpaceRot = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, UserPlaySpaceRot_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlayRate_Offset), 0, null, PlayRate);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<UnrealSharp.GameplayCameras.ECameraAnimationEasingType>.ToNative(IntPtr.Add(Buffer, EaseInType_Offset), 0, null, EaseInType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EaseInDuration_Offset), 0, null, EaseInDuration);
            BlittableMarshaller<UnrealSharp.GameplayCameras.ECameraAnimationEasingType>.ToNative(IntPtr.Add(Buffer, EaseOutType_Offset), 0, null, EaseOutType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EaseOutDuration_Offset), 0, null, EaseOutDuration);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLoop_Offset), 0, null, Loop);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, StartOffset_Offset), 0, null, StartOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRandomStartTime_Offset), 0, null, RandomStartTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DurationOverride_Offset), 0, null, DurationOverride);
            BlittableMarshaller<UnrealSharp.GameplayCameras.ECameraAnimationPlaySpace>.ToNative(IntPtr.Add(Buffer, PlaySpace_Offset), 0, null, PlaySpace);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, UserPlaySpaceRot_Offset), 0, null, UserPlaySpaceRot);
        }
    }
}

public static class CameraAnimationParamsMarshaler
{
    public static CameraAnimationParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraAnimationParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraAnimationParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraAnimationParams.NativeDataSize;
    }
}