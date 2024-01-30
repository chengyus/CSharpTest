using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PoseSnapshot
{
    // NameProperty /Script/Engine.PoseSnapshot:SkeletalMeshName
    static readonly int SkeletalMeshName_Offset;
    public Name SkeletalMeshName;
    
    // NameProperty /Script/Engine.PoseSnapshot:SnapshotName
    static readonly int SnapshotName_Offset;
    public Name SnapshotName;
    
    // BoolProperty /Script/Engine.PoseSnapshot:bIsValid
    static readonly int bIsValid_Offset;
    public bool IsValid;
    
    
    public static readonly int NativeDataSize;
    static PoseSnapshot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PoseSnapshot");
        
        SkeletalMeshName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SkeletalMeshName");
        SnapshotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SnapshotName");
        bIsValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsValid");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PoseSnapshot(IntPtr InNativeStruct)
    {
        unsafe
        {
            SkeletalMeshName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SkeletalMeshName_Offset), 0, null);
            SnapshotName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SnapshotName_Offset), 0, null);
            IsValid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsValid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SkeletalMeshName_Offset), 0, null, SkeletalMeshName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SnapshotName_Offset), 0, null, SnapshotName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsValid_Offset), 0, null, IsValid);
        }
    }
}

public static class PoseSnapshotMarshaler
{
    public static PoseSnapshot FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PoseSnapshot(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PoseSnapshot obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PoseSnapshot.NativeDataSize;
    }
}