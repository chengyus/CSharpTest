using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UStruct]
public partial struct BakingAnimationKeySettings
{
    // StructProperty /Script/MovieSceneTools.BakingAnimationKeySettings:StartFrame
    static readonly int StartFrame_Offset;
    public UnrealSharp.CoreUObject.FrameNumber StartFrame;
    
    // StructProperty /Script/MovieSceneTools.BakingAnimationKeySettings:EndFrame
    static readonly int EndFrame_Offset;
    public UnrealSharp.CoreUObject.FrameNumber EndFrame;
    
    // EnumProperty /Script/MovieSceneTools.BakingAnimationKeySettings:BakingKeySettings
    static readonly int BakingKeySettings_Offset;
    public UnrealSharp.MovieSceneTools.EBakingKeySettings BakingKeySettings;
    
    // IntProperty /Script/MovieSceneTools.BakingAnimationKeySettings:FrameIncrement
    static readonly int FrameIncrement_Offset;
    public int FrameIncrement;
    
    // BoolProperty /Script/MovieSceneTools.BakingAnimationKeySettings:bReduceKeys
    static readonly int bReduceKeys_Offset;
    public bool ReduceKeys;
    
    // FloatProperty /Script/MovieSceneTools.BakingAnimationKeySettings:Tolerance
    static readonly int Tolerance_Offset;
    public float Tolerance;
    
    
    public static readonly int NativeDataSize;
    static BakingAnimationKeySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BakingAnimationKeySettings");
        
        StartFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartFrame");
        EndFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndFrame");
        BakingKeySettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BakingKeySettings");
        FrameIncrement_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameIncrement");
        bReduceKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReduceKeys");
        Tolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tolerance");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BakingAnimationKeySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartFrame = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, StartFrame_Offset), 0, null);
            EndFrame = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, EndFrame_Offset), 0, null);
            BakingKeySettings = BlittableMarshaller<UnrealSharp.MovieSceneTools.EBakingKeySettings>.FromNative(IntPtr.Add(InNativeStruct, BakingKeySettings_Offset), 0, null);
            FrameIncrement = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FrameIncrement_Offset), 0, null);
            ReduceKeys = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bReduceKeys_Offset), 0, null);
            Tolerance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Tolerance_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, StartFrame_Offset), 0, null, StartFrame);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, EndFrame_Offset), 0, null, EndFrame);
            BlittableMarshaller<UnrealSharp.MovieSceneTools.EBakingKeySettings>.ToNative(IntPtr.Add(Buffer, BakingKeySettings_Offset), 0, null, BakingKeySettings);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FrameIncrement_Offset), 0, null, FrameIncrement);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bReduceKeys_Offset), 0, null, ReduceKeys);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Tolerance_Offset), 0, null, Tolerance);
        }
    }
}

public static class BakingAnimationKeySettingsMarshaler
{
    public static BakingAnimationKeySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BakingAnimationKeySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BakingAnimationKeySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BakingAnimationKeySettings.NativeDataSize;
    }
}