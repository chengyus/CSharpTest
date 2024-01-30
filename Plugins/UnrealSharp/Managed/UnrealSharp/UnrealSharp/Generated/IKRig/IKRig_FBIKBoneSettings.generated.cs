// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UClass]
public partial class IKRig_FBIKBoneSettings : UnrealSharp.CoreUObject.Object
{
    
    static IKRig_FBIKBoneSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("IKRig_FBIKBoneSettings");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        RotationStiffness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationStiffness");
        PositionStiffness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionStiffness");
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        MinX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinX");
        MaxX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxX");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        MinY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinY");
        MaxY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxY");
        Z_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Z");
        MinZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinZ");
        MaxZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxZ");
        bUsePreferredAngles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUsePreferredAngles");
        PreferredAngles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreferredAngles");
        
        
        
    }
    
    protected IKRig_FBIKBoneSettings(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // NameProperty /Script/IKRig.IKRig_FBIKBoneSettings:Bone
    static readonly int Bone_Offset;
    
    public Name Bone
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<Name>.FromNative(IntPtr.Add(NativeObject, Bone_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:RotationStiffness
    static readonly int RotationStiffness_Offset;
    
    public float RotationStiffness
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, RotationStiffness_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, RotationStiffness_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:PositionStiffness
    static readonly int PositionStiffness_Offset;
    
    public float PositionStiffness
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, PositionStiffness_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, PositionStiffness_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/IKRig.IKRig_FBIKBoneSettings:X
    static readonly int X_Offset;
    
    public UnrealSharp.PBIK.EPBIKLimitType X
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.PBIK.EPBIKLimitType>.FromNative(IntPtr.Add(NativeObject, X_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.PBIK.EPBIKLimitType>.ToNative(IntPtr.Add(NativeObject, X_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:MinX
    static readonly int MinX_Offset;
    
    public float MinX
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinX_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinX_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:MaxX
    static readonly int MaxX_Offset;
    
    public float MaxX
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxX_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxX_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/IKRig.IKRig_FBIKBoneSettings:Y
    static readonly int Y_Offset;
    
    public UnrealSharp.PBIK.EPBIKLimitType Y
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.PBIK.EPBIKLimitType>.FromNative(IntPtr.Add(NativeObject, Y_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.PBIK.EPBIKLimitType>.ToNative(IntPtr.Add(NativeObject, Y_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:MinY
    static readonly int MinY_Offset;
    
    public float MinY
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinY_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinY_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:MaxY
    static readonly int MaxY_Offset;
    
    public float MaxY
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxY_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxY_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/IKRig.IKRig_FBIKBoneSettings:Z
    static readonly int Z_Offset;
    
    public UnrealSharp.PBIK.EPBIKLimitType Z
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.PBIK.EPBIKLimitType>.FromNative(IntPtr.Add(NativeObject, Z_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.PBIK.EPBIKLimitType>.ToNative(IntPtr.Add(NativeObject, Z_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:MinZ
    static readonly int MinZ_Offset;
    
    public float MinZ
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinZ_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinZ_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_FBIKBoneSettings:MaxZ
    static readonly int MaxZ_Offset;
    
    public float MaxZ
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxZ_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxZ_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/IKRig.IKRig_FBIKBoneSettings:bUsePreferredAngles
    static readonly int bUsePreferredAngles_Offset;
    
    public bool bUsePreferredAngles
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUsePreferredAngles_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUsePreferredAngles_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/IKRig.IKRig_FBIKBoneSettings:PreferredAngles
    static readonly int PreferredAngles_Offset;
    
    public System.DoubleNumerics.Vector3 PreferredAngles
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(NativeObject, PreferredAngles_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(NativeObject, PreferredAngles_Offset), 0, this, value);
        }
    }
    
    
}