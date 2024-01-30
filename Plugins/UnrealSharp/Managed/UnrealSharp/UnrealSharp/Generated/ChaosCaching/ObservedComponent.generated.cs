using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosCaching;

[UStruct]
public partial struct ObservedComponent
{
    // NameProperty /Script/ChaosCaching.ObservedComponent:CacheName
    static readonly int CacheName_Offset;
    public Name CacheName;
    
    // BoolProperty /Script/ChaosCaching.ObservedComponent:bIsSimulating
    static readonly int bIsSimulating_Offset;
    public bool IsSimulating;
    
    // BoolProperty /Script/ChaosCaching.ObservedComponent:bPlaybackEnabled
    static readonly int bPlaybackEnabled_Offset;
    public bool PlaybackEnabled;
    
    
    public static readonly int NativeDataSize;
    static ObservedComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ObservedComponent");
        
        CacheName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CacheName");
        bIsSimulating_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSimulating");
        bPlaybackEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPlaybackEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ObservedComponent(IntPtr InNativeStruct)
    {
        unsafe
        {
            CacheName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, CacheName_Offset), 0, null);
            IsSimulating = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSimulating_Offset), 0, null);
            PlaybackEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPlaybackEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, CacheName_Offset), 0, null, CacheName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSimulating_Offset), 0, null, IsSimulating);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPlaybackEnabled_Offset), 0, null, PlaybackEnabled);
        }
    }
}

public static class ObservedComponentMarshaler
{
    public static ObservedComponent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ObservedComponent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ObservedComponent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ObservedComponent.NativeDataSize;
    }
}