using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScriptingEditor;

[UStruct]
public partial struct SequencerExportFBXParams
{
    // ObjectProperty /Script/SequencerScriptingEditor.SequencerExportFBXParams:World
    static readonly int World_Offset;
    public UnrealSharp.Engine.World World;
    
    // ObjectProperty /Script/SequencerScriptingEditor.SequencerExportFBXParams:Sequence
    static readonly int Sequence_Offset;
    public UnrealSharp.LevelSequence.LevelSequence Sequence;
    
    // ObjectProperty /Script/SequencerScriptingEditor.SequencerExportFBXParams:RootSequence
    static readonly int RootSequence_Offset;
    public UnrealSharp.LevelSequence.LevelSequence RootSequence;
    
    // ObjectProperty /Script/SequencerScriptingEditor.SequencerExportFBXParams:OverrideOptions
    static readonly int OverrideOptions_Offset;
    public UnrealSharp.UnrealEd.FbxExportOption OverrideOptions;
    
    
    public static readonly int NativeDataSize;
    static SequencerExportFBXParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SequencerExportFBXParams");
        
        World_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "World");
        Sequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sequence");
        RootSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootSequence");
        OverrideOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverrideOptions");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SequencerExportFBXParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            World = ObjectMarshaller<UnrealSharp.Engine.World>.FromNative(IntPtr.Add(InNativeStruct, World_Offset), 0, null);
            Sequence = ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.FromNative(IntPtr.Add(InNativeStruct, Sequence_Offset), 0, null);
            RootSequence = ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.FromNative(IntPtr.Add(InNativeStruct, RootSequence_Offset), 0, null);
            OverrideOptions = ObjectMarshaller<UnrealSharp.UnrealEd.FbxExportOption>.FromNative(IntPtr.Add(InNativeStruct, OverrideOptions_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(Buffer, World_Offset), 0, null, World);
            ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.ToNative(IntPtr.Add(Buffer, Sequence_Offset), 0, null, Sequence);
            ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.ToNative(IntPtr.Add(Buffer, RootSequence_Offset), 0, null, RootSequence);
            ObjectMarshaller<UnrealSharp.UnrealEd.FbxExportOption>.ToNative(IntPtr.Add(Buffer, OverrideOptions_Offset), 0, null, OverrideOptions);
        }
    }
}

public static class SequencerExportFBXParamsMarshaler
{
    public static SequencerExportFBXParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SequencerExportFBXParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SequencerExportFBXParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SequencerExportFBXParams.NativeDataSize;
    }
}