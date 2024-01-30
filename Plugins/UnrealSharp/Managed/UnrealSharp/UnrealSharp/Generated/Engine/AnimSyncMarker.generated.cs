using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimSyncMarker
{
    // NameProperty /Script/Engine.AnimSyncMarker:MarkerName
    static readonly int MarkerName_Offset;
    public Name MarkerName;
    
    // FloatProperty /Script/Engine.AnimSyncMarker:Time
    static readonly int Time_Offset;
    public float Time;
    
    
    public static readonly int NativeDataSize;
    static AnimSyncMarker()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimSyncMarker");
        
        MarkerName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MarkerName");
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimSyncMarker(IntPtr InNativeStruct)
    {
        unsafe
        {
            MarkerName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, MarkerName_Offset), 0, null);
            Time = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Time_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, MarkerName_Offset), 0, null, MarkerName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Time_Offset), 0, null, Time);
        }
    }
}

public static class AnimSyncMarkerMarshaler
{
    public static AnimSyncMarker FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimSyncMarker(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimSyncMarker obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimSyncMarker.NativeDataSize;
    }
}