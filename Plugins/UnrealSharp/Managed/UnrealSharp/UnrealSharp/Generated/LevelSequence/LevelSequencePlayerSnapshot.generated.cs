using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequence;

[UStruct]
public partial struct LevelSequencePlayerSnapshot
{
    // StructProperty /Script/LevelSequence.LevelSequencePlayerSnapshot:RootTime
    static readonly int RootTime_Offset;
    public UnrealSharp.CoreUObject.QualifiedTime RootTime;
    
    // StructProperty /Script/LevelSequence.LevelSequencePlayerSnapshot:SourceTime
    static readonly int SourceTime_Offset;
    public UnrealSharp.CoreUObject.QualifiedTime SourceTime;
    
    // StructProperty /Script/LevelSequence.LevelSequencePlayerSnapshot:CurrentShotLocalTime
    static readonly int CurrentShotLocalTime_Offset;
    public UnrealSharp.CoreUObject.QualifiedTime CurrentShotLocalTime;
    
    // StructProperty /Script/LevelSequence.LevelSequencePlayerSnapshot:CurrentShotSourceTime
    static readonly int CurrentShotSourceTime_Offset;
    public UnrealSharp.CoreUObject.QualifiedTime CurrentShotSourceTime;
    
    // SoftObjectProperty /Script/LevelSequence.LevelSequencePlayerSnapshot:CameraComponent
    static readonly int CameraComponent_Offset;
    public SoftObject<UnrealSharp.Engine.CameraComponent> CameraComponent;
    
    // ObjectProperty /Script/LevelSequence.LevelSequencePlayerSnapshot:ActiveShot
    static readonly int ActiveShot_Offset;
    public UnrealSharp.LevelSequence.LevelSequence ActiveShot;
    
    
    public static readonly int NativeDataSize;
    static LevelSequencePlayerSnapshot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LevelSequencePlayerSnapshot");
        
        RootTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootTime");
        SourceTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceTime");
        CurrentShotLocalTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurrentShotLocalTime");
        CurrentShotSourceTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurrentShotSourceTime");
        CameraComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CameraComponent");
        ActiveShot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveShot");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LevelSequencePlayerSnapshot(IntPtr InNativeStruct)
    {
        unsafe
        {
            RootTime = BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.FromNative(IntPtr.Add(InNativeStruct, RootTime_Offset), 0, null);
            SourceTime = BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.FromNative(IntPtr.Add(InNativeStruct, SourceTime_Offset), 0, null);
            CurrentShotLocalTime = BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.FromNative(IntPtr.Add(InNativeStruct, CurrentShotLocalTime_Offset), 0, null);
            CurrentShotSourceTime = BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.FromNative(IntPtr.Add(InNativeStruct, CurrentShotSourceTime_Offset), 0, null);
            CameraComponent = BlittableMarshaller<SoftObject<UnrealSharp.Engine.CameraComponent>>.FromNative(IntPtr.Add(InNativeStruct, CameraComponent_Offset), 0, null);
            ActiveShot = ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.FromNative(IntPtr.Add(InNativeStruct, ActiveShot_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.ToNative(IntPtr.Add(Buffer, RootTime_Offset), 0, null, RootTime);
            BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.ToNative(IntPtr.Add(Buffer, SourceTime_Offset), 0, null, SourceTime);
            BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.ToNative(IntPtr.Add(Buffer, CurrentShotLocalTime_Offset), 0, null, CurrentShotLocalTime);
            BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.ToNative(IntPtr.Add(Buffer, CurrentShotSourceTime_Offset), 0, null, CurrentShotSourceTime);
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.CameraComponent>>.ToNative(IntPtr.Add(Buffer, CameraComponent_Offset), 0, null, CameraComponent);
            ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.ToNative(IntPtr.Add(Buffer, ActiveShot_Offset), 0, null, ActiveShot);
        }
    }
}

public static class LevelSequencePlayerSnapshotMarshaler
{
    public static LevelSequencePlayerSnapshot FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LevelSequencePlayerSnapshot(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LevelSequencePlayerSnapshot obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LevelSequencePlayerSnapshot.NativeDataSize;
    }
}