// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UClass]
public partial class CameraRig_Crane : UnrealSharp.Engine.Actor
{
    
    static CameraRig_Crane()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CameraRig_Crane");
        
        CranePitch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CranePitch");
        CraneYaw_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CraneYaw");
        CraneArmLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CraneArmLength");
        bLockMountPitch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLockMountPitch");
        bLockMountYaw_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLockMountYaw");
        
        
        
    }
    
    protected CameraRig_Crane(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/CinematicCamera.CameraRig_Crane:CranePitch
    static readonly int CranePitch_Offset;
    
    public float CranePitch
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CranePitch_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, CranePitch_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/CinematicCamera.CameraRig_Crane:CraneYaw
    static readonly int CraneYaw_Offset;
    
    public float CraneYaw
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CraneYaw_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, CraneYaw_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/CinematicCamera.CameraRig_Crane:CraneArmLength
    static readonly int CraneArmLength_Offset;
    
    public float CraneArmLength
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CraneArmLength_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, CraneArmLength_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/CinematicCamera.CameraRig_Crane:bLockMountPitch
    static readonly int bLockMountPitch_Offset;
    
    public bool bLockMountPitch
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLockMountPitch_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLockMountPitch_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/CinematicCamera.CameraRig_Crane:bLockMountYaw
    static readonly int bLockMountYaw_Offset;
    
    public bool bLockMountYaw
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLockMountYaw_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLockMountYaw_Offset), 0, this, value);
        }
    }
    
    
}