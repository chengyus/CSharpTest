using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequenceEditor;

[UStruct]
public partial struct SequencerChannelProxy
{
    // NameProperty /Script/LevelSequenceEditor.SequencerChannelProxy:ChannelName
    static readonly int ChannelName_Offset;
    public Name ChannelName;
    
    // ObjectProperty /Script/LevelSequenceEditor.SequencerChannelProxy:Section
    static readonly int Section_Offset;
    public UnrealSharp.MovieScene.MovieSceneSection Section;
    
    
    public static readonly int NativeDataSize;
    static SequencerChannelProxy()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SequencerChannelProxy");
        
        ChannelName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChannelName");
        Section_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Section");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SequencerChannelProxy(IntPtr InNativeStruct)
    {
        unsafe
        {
            ChannelName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ChannelName_Offset), 0, null);
            Section = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSection>.FromNative(IntPtr.Add(InNativeStruct, Section_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ChannelName_Offset), 0, null, ChannelName);
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSection>.ToNative(IntPtr.Add(Buffer, Section_Offset), 0, null, Section);
        }
    }
}

public static class SequencerChannelProxyMarshaler
{
    public static SequencerChannelProxy FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SequencerChannelProxy(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SequencerChannelProxy obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SequencerChannelProxy.NativeDataSize;
    }
}