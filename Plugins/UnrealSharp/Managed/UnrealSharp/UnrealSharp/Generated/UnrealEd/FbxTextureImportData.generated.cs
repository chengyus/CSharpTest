// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UClass]
public partial class FbxTextureImportData : UnrealSharp.UnrealEd.FbxAssetImportData
{
    
    static FbxTextureImportData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FbxTextureImportData");
        
        bInvertNormalMaps_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInvertNormalMaps");
        bInvertNormalMaps_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bInvertNormalMaps");
        MaterialSearchLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaterialSearchLocation");
        BaseMaterialName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseMaterialName");
        BaseColorName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseColorName");
        BaseColorName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseColorName");
        BaseDiffuseTextureName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseDiffuseTextureName");
        BaseDiffuseTextureName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseDiffuseTextureName");
        BaseNormalTextureName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseNormalTextureName");
        BaseNormalTextureName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseNormalTextureName");
        BaseEmissiveColorName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseEmissiveColorName");
        BaseEmissiveColorName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseEmissiveColorName");
        BaseEmmisiveTextureName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseEmmisiveTextureName");
        BaseEmmisiveTextureName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseEmmisiveTextureName");
        BaseSpecularTextureName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseSpecularTextureName");
        BaseSpecularTextureName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseSpecularTextureName");
        BaseOpacityTextureName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseOpacityTextureName");
        BaseOpacityTextureName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseOpacityTextureName");
        
        
        
    }
    
    protected FbxTextureImportData(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/UnrealEd.FbxTextureImportData:bInvertNormalMaps
    static readonly int bInvertNormalMaps_Offset;
    static readonly IntPtr bInvertNormalMaps_NativeProperty;
    
    public bool bInvertNormalMaps
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bInvertNormalMaps_NativeProperty, bInvertNormalMaps_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bInvertNormalMaps_NativeProperty, bInvertNormalMaps_Offset, value);
        }
    }
    
    // EnumProperty /Script/UnrealEd.FbxTextureImportData:MaterialSearchLocation
    static readonly int MaterialSearchLocation_Offset;
    
    public UnrealSharp.UnrealEd.EMaterialSearchLocation MaterialSearchLocation
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.UnrealEd.EMaterialSearchLocation>.FromNative(IntPtr.Add(NativeObject, MaterialSearchLocation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.UnrealEd.EMaterialSearchLocation>.ToNative(IntPtr.Add(NativeObject, MaterialSearchLocation_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UnrealEd.FbxTextureImportData:BaseMaterialName
    static readonly int BaseMaterialName_Offset;
    
    public UnrealSharp.CoreUObject.SoftObjectPath BaseMaterialName
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(NativeObject, BaseMaterialName_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.CoreUObject.SoftObjectPathMarshaler.ToNative(IntPtr.Add(NativeObject, BaseMaterialName_Offset), 0, this, value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseColorName
    static readonly int BaseColorName_Offset;
    static readonly IntPtr BaseColorName_NativeProperty;
    
    public string BaseColorName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseColorName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseColorName_Offset),0,this,value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseDiffuseTextureName
    static readonly int BaseDiffuseTextureName_Offset;
    static readonly IntPtr BaseDiffuseTextureName_NativeProperty;
    
    public string BaseDiffuseTextureName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseDiffuseTextureName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseDiffuseTextureName_Offset),0,this,value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseNormalTextureName
    static readonly int BaseNormalTextureName_Offset;
    static readonly IntPtr BaseNormalTextureName_NativeProperty;
    
    public string BaseNormalTextureName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseNormalTextureName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseNormalTextureName_Offset),0,this,value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseEmissiveColorName
    static readonly int BaseEmissiveColorName_Offset;
    static readonly IntPtr BaseEmissiveColorName_NativeProperty;
    
    public string BaseEmissiveColorName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseEmissiveColorName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseEmissiveColorName_Offset),0,this,value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseEmmisiveTextureName
    static readonly int BaseEmmisiveTextureName_Offset;
    static readonly IntPtr BaseEmmisiveTextureName_NativeProperty;
    
    public string BaseEmmisiveTextureName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseEmmisiveTextureName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseEmmisiveTextureName_Offset),0,this,value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseSpecularTextureName
    static readonly int BaseSpecularTextureName_Offset;
    static readonly IntPtr BaseSpecularTextureName_NativeProperty;
    
    public string BaseSpecularTextureName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseSpecularTextureName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseSpecularTextureName_Offset),0,this,value);
        }
    }
    
    // StrProperty /Script/UnrealEd.FbxTextureImportData:BaseOpacityTextureName
    static readonly int BaseOpacityTextureName_Offset;
    static readonly IntPtr BaseOpacityTextureName_NativeProperty;
    
    public string BaseOpacityTextureName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,BaseOpacityTextureName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,BaseOpacityTextureName_Offset),0,this,value);
        }
    }
    
    
}