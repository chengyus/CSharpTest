using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SingleAnimationPlayData
{
    // ObjectProperty /Script/Engine.SingleAnimationPlayData:AnimToPlay
    static readonly int AnimToPlay_Offset;
    public UnrealSharp.Engine.AnimationAsset AnimToPlay;
    
    // BoolProperty /Script/Engine.SingleAnimationPlayData:bSavedLooping
    static readonly int bSavedLooping_Offset;
    static readonly IntPtr bSavedLooping_NativeProperty;
    public bool SavedLooping;
    
    // BoolProperty /Script/Engine.SingleAnimationPlayData:bSavedPlaying
    static readonly int bSavedPlaying_Offset;
    static readonly IntPtr bSavedPlaying_NativeProperty;
    public bool SavedPlaying;
    
    // FloatProperty /Script/Engine.SingleAnimationPlayData:SavedPosition
    static readonly int SavedPosition_Offset;
    public float SavedPosition;
    
    // FloatProperty /Script/Engine.SingleAnimationPlayData:SavedPlayRate
    static readonly int SavedPlayRate_Offset;
    public float SavedPlayRate;
    
    
    public static readonly int NativeDataSize;
    static SingleAnimationPlayData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SingleAnimationPlayData");
        
        AnimToPlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AnimToPlay");
        bSavedLooping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSavedLooping");
        bSavedLooping_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSavedLooping");
        bSavedPlaying_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSavedPlaying");
        bSavedPlaying_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSavedPlaying");
        SavedPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SavedPosition");
        SavedPlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SavedPlayRate");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SingleAnimationPlayData(IntPtr InNativeStruct)
    {
        unsafe
        {
            AnimToPlay = ObjectMarshaller<UnrealSharp.Engine.AnimationAsset>.FromNative(IntPtr.Add(InNativeStruct, AnimToPlay_Offset), 0, null);
            SavedLooping = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSavedLooping_NativeProperty, bSavedLooping_Offset);
            SavedPlaying = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSavedPlaying_NativeProperty, bSavedPlaying_Offset);
            SavedPosition = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SavedPosition_Offset), 0, null);
            SavedPlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SavedPlayRate_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.AnimationAsset>.ToNative(IntPtr.Add(Buffer, AnimToPlay_Offset), 0, null, AnimToPlay);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSavedLooping_NativeProperty, bSavedLooping_Offset, SavedLooping);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSavedPlaying_NativeProperty, bSavedPlaying_Offset, SavedPlaying);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SavedPosition_Offset), 0, null, SavedPosition);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SavedPlayRate_Offset), 0, null, SavedPlayRate);
        }
    }
}

public static class SingleAnimationPlayDataMarshaler
{
    public static SingleAnimationPlayData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SingleAnimationPlayData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SingleAnimationPlayData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SingleAnimationPlayData.NativeDataSize;
    }
}