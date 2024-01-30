using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequence;

[UStruct]
public partial struct LevelSequenceCameraSettings
{
    // BoolProperty /Script/LevelSequence.LevelSequenceCameraSettings:bOverrideAspectRatioAxisConstraint
    static readonly int bOverrideAspectRatioAxisConstraint_Offset;
    public bool OverrideAspectRatioAxisConstraint;
    
    // ByteProperty /Script/LevelSequence.LevelSequenceCameraSettings:AspectRatioAxisConstraint
    static readonly int AspectRatioAxisConstraint_Offset;
    public UnrealSharp.Engine.EAspectRatioAxisConstraint AspectRatioAxisConstraint;
    
    
    public static readonly int NativeDataSize;
    static LevelSequenceCameraSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LevelSequenceCameraSettings");
        
        bOverrideAspectRatioAxisConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideAspectRatioAxisConstraint");
        AspectRatioAxisConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AspectRatioAxisConstraint");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LevelSequenceCameraSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            OverrideAspectRatioAxisConstraint = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverrideAspectRatioAxisConstraint_Offset), 0, null);
            AspectRatioAxisConstraint = BlittableMarshaller<UnrealSharp.Engine.EAspectRatioAxisConstraint>.FromNative(IntPtr.Add(InNativeStruct, AspectRatioAxisConstraint_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverrideAspectRatioAxisConstraint_Offset), 0, null, OverrideAspectRatioAxisConstraint);
            BlittableMarshaller<UnrealSharp.Engine.EAspectRatioAxisConstraint>.ToNative(IntPtr.Add(Buffer, AspectRatioAxisConstraint_Offset), 0, null, AspectRatioAxisConstraint);
        }
    }
}

public static class LevelSequenceCameraSettingsMarshaler
{
    public static LevelSequenceCameraSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LevelSequenceCameraSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LevelSequenceCameraSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LevelSequenceCameraSettings.NativeDataSize;
    }
}