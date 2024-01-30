using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct BoneAnimationTrack
{
    // StructProperty /Script/Engine.BoneAnimationTrack:InternalTrackData
    static readonly int InternalTrackData_Offset;
    public UnrealSharp.Engine.RawAnimSequenceTrack InternalTrackData;
    
    // IntProperty /Script/Engine.BoneAnimationTrack:BoneTreeIndex
    static readonly int BoneTreeIndex_Offset;
    public int BoneTreeIndex;
    
    // NameProperty /Script/Engine.BoneAnimationTrack:Name
    static readonly int Name_Offset;
    public Name Name;
    
    
    public static readonly int NativeDataSize;
    static BoneAnimationTrack()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BoneAnimationTrack");
        
        InternalTrackData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InternalTrackData");
        BoneTreeIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneTreeIndex");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BoneAnimationTrack(IntPtr InNativeStruct)
    {
        unsafe
        {
            InternalTrackData = UnrealSharp.Engine.RawAnimSequenceTrackMarshaler.FromNative(IntPtr.Add(InNativeStruct, InternalTrackData_Offset), 0, null);
            BoneTreeIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BoneTreeIndex_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.RawAnimSequenceTrackMarshaler.ToNative(IntPtr.Add(Buffer, InternalTrackData_Offset), 0, null, InternalTrackData);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BoneTreeIndex_Offset), 0, null, BoneTreeIndex);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
        }
    }
}

public static class BoneAnimationTrackMarshaler
{
    public static BoneAnimationTrack FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BoneAnimationTrack(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BoneAnimationTrack obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BoneAnimationTrack.NativeDataSize;
    }
}