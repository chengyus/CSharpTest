// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UClass]
public partial class FbxExportOption : UnrealSharp.CoreUObject.Object
{
    
    static FbxExportOption()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FbxExportOption");
        
        FbxExportCompatibility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FbxExportCompatibility");
        bASCII_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bASCII");
        bASCII_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bASCII");
        bForceFrontXAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceFrontXAxis");
        bForceFrontXAxis_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bForceFrontXAxis");
        VertexColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VertexColor");
        VertexColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "VertexColor");
        LevelOfDetail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LevelOfDetail");
        LevelOfDetail_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LevelOfDetail");
        Collision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collision");
        Collision_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Collision");
        bExportSourceMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportSourceMesh");
        bExportSourceMesh_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExportSourceMesh");
        bExportMorphTargets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportMorphTargets");
        bExportMorphTargets_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExportMorphTargets");
        bExportPreviewMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportPreviewMesh");
        bExportPreviewMesh_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExportPreviewMesh");
        MapSkeletalMotionToRoot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MapSkeletalMotionToRoot");
        MapSkeletalMotionToRoot_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "MapSkeletalMotionToRoot");
        bExportLocalTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportLocalTime");
        bExportLocalTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExportLocalTime");
        
        
        
    }
    
    protected FbxExportOption(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // EnumProperty /Script/UnrealEd.FbxExportOption:FbxExportCompatibility
    static readonly int FbxExportCompatibility_Offset;
    
    public UnrealSharp.UnrealEd.EFbxExportCompatibility FbxExportCompatibility
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.UnrealEd.EFbxExportCompatibility>.FromNative(IntPtr.Add(NativeObject, FbxExportCompatibility_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.UnrealEd.EFbxExportCompatibility>.ToNative(IntPtr.Add(NativeObject, FbxExportCompatibility_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:bASCII
    static readonly int bASCII_Offset;
    static readonly IntPtr bASCII_NativeProperty;
    
    public bool bASCII
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bASCII_NativeProperty, bASCII_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bASCII_NativeProperty, bASCII_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:bForceFrontXAxis
    static readonly int bForceFrontXAxis_Offset;
    static readonly IntPtr bForceFrontXAxis_NativeProperty;
    
    public bool bForceFrontXAxis
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bForceFrontXAxis_NativeProperty, bForceFrontXAxis_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bForceFrontXAxis_NativeProperty, bForceFrontXAxis_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:VertexColor
    static readonly int VertexColor_Offset;
    static readonly IntPtr VertexColor_NativeProperty;
    
    public bool VertexColor
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, VertexColor_NativeProperty, VertexColor_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, VertexColor_NativeProperty, VertexColor_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:LevelOfDetail
    static readonly int LevelOfDetail_Offset;
    static readonly IntPtr LevelOfDetail_NativeProperty;
    
    public bool LevelOfDetail
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, LevelOfDetail_NativeProperty, LevelOfDetail_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, LevelOfDetail_NativeProperty, LevelOfDetail_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:Collision
    static readonly int Collision_Offset;
    static readonly IntPtr Collision_NativeProperty;
    
    public bool Collision
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, Collision_NativeProperty, Collision_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, Collision_NativeProperty, Collision_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:bExportSourceMesh
    static readonly int bExportSourceMesh_Offset;
    static readonly IntPtr bExportSourceMesh_NativeProperty;
    
    public bool bExportSourceMesh
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bExportSourceMesh_NativeProperty, bExportSourceMesh_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bExportSourceMesh_NativeProperty, bExportSourceMesh_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:bExportMorphTargets
    static readonly int bExportMorphTargets_Offset;
    static readonly IntPtr bExportMorphTargets_NativeProperty;
    
    public bool bExportMorphTargets
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bExportMorphTargets_NativeProperty, bExportMorphTargets_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bExportMorphTargets_NativeProperty, bExportMorphTargets_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:bExportPreviewMesh
    static readonly int bExportPreviewMesh_Offset;
    static readonly IntPtr bExportPreviewMesh_NativeProperty;
    
    public bool bExportPreviewMesh
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bExportPreviewMesh_NativeProperty, bExportPreviewMesh_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bExportPreviewMesh_NativeProperty, bExportPreviewMesh_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:MapSkeletalMotionToRoot
    static readonly int MapSkeletalMotionToRoot_Offset;
    static readonly IntPtr MapSkeletalMotionToRoot_NativeProperty;
    
    public bool MapSkeletalMotionToRoot
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, MapSkeletalMotionToRoot_NativeProperty, MapSkeletalMotionToRoot_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, MapSkeletalMotionToRoot_NativeProperty, MapSkeletalMotionToRoot_Offset, value);
        }
    }
    
    // BoolProperty /Script/UnrealEd.FbxExportOption:bExportLocalTime
    static readonly int bExportLocalTime_Offset;
    static readonly IntPtr bExportLocalTime_NativeProperty;
    
    public bool bExportLocalTime
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bExportLocalTime_NativeProperty, bExportLocalTime_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bExportLocalTime_NativeProperty, bExportLocalTime_Offset, value);
        }
    }
    
    
}