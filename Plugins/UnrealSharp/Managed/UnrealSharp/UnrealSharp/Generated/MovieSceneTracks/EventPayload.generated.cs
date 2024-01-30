using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UStruct]
public partial struct EventPayload
{
    // NameProperty /Script/MovieSceneTracks.EventPayload:EventName
    static readonly int EventName_Offset;
    public Name EventName;
    
    // StructProperty /Script/MovieSceneTracks.EventPayload:Parameters
    static readonly int Parameters_Offset;
    public UnrealSharp.MovieSceneTracks.MovieSceneEventParameters Parameters;
    
    
    public static readonly int NativeDataSize;
    static EventPayload()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EventPayload");
        
        EventName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EventName");
        Parameters_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parameters");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EventPayload(IntPtr InNativeStruct)
    {
        unsafe
        {
            EventName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EventName_Offset), 0, null);
            Parameters = UnrealSharp.MovieSceneTracks.MovieSceneEventParametersMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parameters_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EventName_Offset), 0, null, EventName);
            UnrealSharp.MovieSceneTracks.MovieSceneEventParametersMarshaler.ToNative(IntPtr.Add(Buffer, Parameters_Offset), 0, null, Parameters);
        }
    }
}

public static class EventPayloadMarshaler
{
    public static EventPayload FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EventPayload(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EventPayload obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EventPayload.NativeDataSize;
    }
}