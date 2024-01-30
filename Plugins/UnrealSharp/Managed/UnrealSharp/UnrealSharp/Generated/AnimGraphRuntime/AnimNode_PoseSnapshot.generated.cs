using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_PoseSnapshot
{
    // NameProperty /Script/AnimGraphRuntime.AnimNode_PoseSnapshot:SnapshotName
    static readonly int SnapshotName_Offset;
    public Name SnapshotName;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_PoseSnapshot:Snapshot
    static readonly int Snapshot_Offset;
    public UnrealSharp.Engine.PoseSnapshot Snapshot;
    
    // EnumProperty /Script/AnimGraphRuntime.AnimNode_PoseSnapshot:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.AnimGraphRuntime.ESnapshotSourceMode Mode;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_PoseSnapshot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_PoseSnapshot");
        
        SnapshotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SnapshotName");
        Snapshot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Snapshot");
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_PoseSnapshot(IntPtr InNativeStruct)
    {
        unsafe
        {
            SnapshotName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SnapshotName_Offset), 0, null);
            Snapshot = UnrealSharp.Engine.PoseSnapshotMarshaler.FromNative(IntPtr.Add(InNativeStruct, Snapshot_Offset), 0, null);
            Mode = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ESnapshotSourceMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SnapshotName_Offset), 0, null, SnapshotName);
            UnrealSharp.Engine.PoseSnapshotMarshaler.ToNative(IntPtr.Add(Buffer, Snapshot_Offset), 0, null, Snapshot);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ESnapshotSourceMode>.ToNative(IntPtr.Add(Buffer, Mode_Offset), 0, null, Mode);
        }
    }
}

public static class AnimNode_PoseSnapshotMarshaler
{
    public static AnimNode_PoseSnapshot FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_PoseSnapshot(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_PoseSnapshot obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_PoseSnapshot.NativeDataSize;
    }
}