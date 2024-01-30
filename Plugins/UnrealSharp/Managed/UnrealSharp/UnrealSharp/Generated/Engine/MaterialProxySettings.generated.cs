using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MaterialProxySettings
{
    // ByteProperty /Script/Engine.MaterialProxySettings:TextureSizingType
    static readonly int TextureSizingType_Offset;
    public UnrealSharp.Engine.ETextureSizingType TextureSizingType;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:TargetTexelDensityPerMeter
    static readonly int TargetTexelDensityPerMeter_Offset;
    public float TargetTexelDensityPerMeter;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:MeshMaxScreenSizePercent
    static readonly int MeshMaxScreenSizePercent_Offset;
    public float MeshMaxScreenSizePercent;
    
    // DoubleProperty /Script/Engine.MaterialProxySettings:MeshMinDrawDistance
    static readonly int MeshMinDrawDistance_Offset;
    public double MeshMinDrawDistance;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:GutterSpace
    static readonly int GutterSpace_Offset;
    public float GutterSpace;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:MetallicConstant
    static readonly int MetallicConstant_Offset;
    public float MetallicConstant;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:RoughnessConstant
    static readonly int RoughnessConstant_Offset;
    public float RoughnessConstant;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:AnisotropyConstant
    static readonly int AnisotropyConstant_Offset;
    public float AnisotropyConstant;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:SpecularConstant
    static readonly int SpecularConstant_Offset;
    public float SpecularConstant;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:OpacityConstant
    static readonly int OpacityConstant_Offset;
    public float OpacityConstant;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:OpacityMaskConstant
    static readonly int OpacityMaskConstant_Offset;
    public float OpacityMaskConstant;
    
    // FloatProperty /Script/Engine.MaterialProxySettings:AmbientOcclusionConstant
    static readonly int AmbientOcclusionConstant_Offset;
    public float AmbientOcclusionConstant;
    
    // ByteProperty /Script/Engine.MaterialProxySettings:BlendMode
    static readonly int BlendMode_Offset;
    public UnrealSharp.Engine.EBlendMode BlendMode;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bAllowTwoSidedMaterial
    static readonly int bAllowTwoSidedMaterial_Offset;
    static readonly IntPtr bAllowTwoSidedMaterial_NativeProperty;
    public bool AllowTwoSidedMaterial;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bNormalMap
    static readonly int bNormalMap_Offset;
    static readonly IntPtr bNormalMap_NativeProperty;
    public bool NormalMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bTangentMap
    static readonly int bTangentMap_Offset;
    static readonly IntPtr bTangentMap_NativeProperty;
    public bool TangentMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bMetallicMap
    static readonly int bMetallicMap_Offset;
    static readonly IntPtr bMetallicMap_NativeProperty;
    public bool MetallicMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bRoughnessMap
    static readonly int bRoughnessMap_Offset;
    static readonly IntPtr bRoughnessMap_NativeProperty;
    public bool RoughnessMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bAnisotropyMap
    static readonly int bAnisotropyMap_Offset;
    static readonly IntPtr bAnisotropyMap_NativeProperty;
    public bool AnisotropyMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bSpecularMap
    static readonly int bSpecularMap_Offset;
    static readonly IntPtr bSpecularMap_NativeProperty;
    public bool SpecularMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bEmissiveMap
    static readonly int bEmissiveMap_Offset;
    static readonly IntPtr bEmissiveMap_NativeProperty;
    public bool EmissiveMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bOpacityMap
    static readonly int bOpacityMap_Offset;
    static readonly IntPtr bOpacityMap_NativeProperty;
    public bool OpacityMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bOpacityMaskMap
    static readonly int bOpacityMaskMap_Offset;
    static readonly IntPtr bOpacityMaskMap_NativeProperty;
    public bool OpacityMaskMap;
    
    // BoolProperty /Script/Engine.MaterialProxySettings:bAmbientOcclusionMap
    static readonly int bAmbientOcclusionMap_Offset;
    static readonly IntPtr bAmbientOcclusionMap_NativeProperty;
    public bool AmbientOcclusionMap;
    
    // StructProperty /Script/Engine.MaterialProxySettings:DiffuseTextureSize
    static readonly int DiffuseTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint DiffuseTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:NormalTextureSize
    static readonly int NormalTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint NormalTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:TangentTextureSize
    static readonly int TangentTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint TangentTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:MetallicTextureSize
    static readonly int MetallicTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint MetallicTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:RoughnessTextureSize
    static readonly int RoughnessTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint RoughnessTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:AnisotropyTextureSize
    static readonly int AnisotropyTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint AnisotropyTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:SpecularTextureSize
    static readonly int SpecularTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint SpecularTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:EmissiveTextureSize
    static readonly int EmissiveTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint EmissiveTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:OpacityTextureSize
    static readonly int OpacityTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint OpacityTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:OpacityMaskTextureSize
    static readonly int OpacityMaskTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint OpacityMaskTextureSize;
    
    // StructProperty /Script/Engine.MaterialProxySettings:AmbientOcclusionTextureSize
    static readonly int AmbientOcclusionTextureSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint AmbientOcclusionTextureSize;
    
    
    public static readonly int NativeDataSize;
    static MaterialProxySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MaterialProxySettings");
        
        TextureSizingType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextureSizingType");
        TargetTexelDensityPerMeter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetTexelDensityPerMeter");
        MeshMaxScreenSizePercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshMaxScreenSizePercent");
        MeshMinDrawDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshMinDrawDistance");
        GutterSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GutterSpace");
        MetallicConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MetallicConstant");
        RoughnessConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RoughnessConstant");
        AnisotropyConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AnisotropyConstant");
        SpecularConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpecularConstant");
        OpacityConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OpacityConstant");
        OpacityMaskConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OpacityMaskConstant");
        AmbientOcclusionConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionConstant");
        BlendMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendMode");
        bAllowTwoSidedMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowTwoSidedMaterial");
        bAllowTwoSidedMaterial_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowTwoSidedMaterial");
        bNormalMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNormalMap");
        bNormalMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bNormalMap");
        bTangentMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTangentMap");
        bTangentMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bTangentMap");
        bMetallicMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMetallicMap");
        bMetallicMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMetallicMap");
        bRoughnessMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRoughnessMap");
        bRoughnessMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRoughnessMap");
        bAnisotropyMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAnisotropyMap");
        bAnisotropyMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAnisotropyMap");
        bSpecularMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpecularMap");
        bSpecularMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSpecularMap");
        bEmissiveMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEmissiveMap");
        bEmissiveMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEmissiveMap");
        bOpacityMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOpacityMap");
        bOpacityMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOpacityMap");
        bOpacityMaskMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOpacityMaskMap");
        bOpacityMaskMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOpacityMaskMap");
        bAmbientOcclusionMap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAmbientOcclusionMap");
        bAmbientOcclusionMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAmbientOcclusionMap");
        DiffuseTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DiffuseTextureSize");
        NormalTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalTextureSize");
        TangentTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TangentTextureSize");
        MetallicTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MetallicTextureSize");
        RoughnessTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RoughnessTextureSize");
        AnisotropyTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AnisotropyTextureSize");
        SpecularTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpecularTextureSize");
        EmissiveTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EmissiveTextureSize");
        OpacityTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OpacityTextureSize");
        OpacityMaskTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OpacityMaskTextureSize");
        AmbientOcclusionTextureSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionTextureSize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MaterialProxySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            TextureSizingType = BlittableMarshaller<UnrealSharp.Engine.ETextureSizingType>.FromNative(IntPtr.Add(InNativeStruct, TextureSizingType_Offset), 0, null);
            TargetTexelDensityPerMeter = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetTexelDensityPerMeter_Offset), 0, null);
            MeshMaxScreenSizePercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MeshMaxScreenSizePercent_Offset), 0, null);
            MeshMinDrawDistance = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, MeshMinDrawDistance_Offset), 0, null);
            GutterSpace = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GutterSpace_Offset), 0, null);
            MetallicConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MetallicConstant_Offset), 0, null);
            RoughnessConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RoughnessConstant_Offset), 0, null);
            AnisotropyConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AnisotropyConstant_Offset), 0, null);
            SpecularConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpecularConstant_Offset), 0, null);
            OpacityConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OpacityConstant_Offset), 0, null);
            OpacityMaskConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OpacityMaskConstant_Offset), 0, null);
            AmbientOcclusionConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionConstant_Offset), 0, null);
            BlendMode = BlittableMarshaller<UnrealSharp.Engine.EBlendMode>.FromNative(IntPtr.Add(InNativeStruct, BlendMode_Offset), 0, null);
            AllowTwoSidedMaterial = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowTwoSidedMaterial_NativeProperty, bAllowTwoSidedMaterial_Offset);
            NormalMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bNormalMap_NativeProperty, bNormalMap_Offset);
            TangentMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bTangentMap_NativeProperty, bTangentMap_Offset);
            MetallicMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMetallicMap_NativeProperty, bMetallicMap_Offset);
            RoughnessMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRoughnessMap_NativeProperty, bRoughnessMap_Offset);
            AnisotropyMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAnisotropyMap_NativeProperty, bAnisotropyMap_Offset);
            SpecularMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSpecularMap_NativeProperty, bSpecularMap_Offset);
            EmissiveMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEmissiveMap_NativeProperty, bEmissiveMap_Offset);
            OpacityMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOpacityMap_NativeProperty, bOpacityMap_Offset);
            OpacityMaskMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOpacityMaskMap_NativeProperty, bOpacityMaskMap_Offset);
            AmbientOcclusionMap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAmbientOcclusionMap_NativeProperty, bAmbientOcclusionMap_Offset);
            DiffuseTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, DiffuseTextureSize_Offset), 0, null);
            NormalTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, NormalTextureSize_Offset), 0, null);
            TangentTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, TangentTextureSize_Offset), 0, null);
            MetallicTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, MetallicTextureSize_Offset), 0, null);
            RoughnessTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, RoughnessTextureSize_Offset), 0, null);
            AnisotropyTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, AnisotropyTextureSize_Offset), 0, null);
            SpecularTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, SpecularTextureSize_Offset), 0, null);
            EmissiveTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, EmissiveTextureSize_Offset), 0, null);
            OpacityTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, OpacityTextureSize_Offset), 0, null);
            OpacityMaskTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, OpacityMaskTextureSize_Offset), 0, null);
            AmbientOcclusionTextureSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionTextureSize_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.ETextureSizingType>.ToNative(IntPtr.Add(Buffer, TextureSizingType_Offset), 0, null, TextureSizingType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetTexelDensityPerMeter_Offset), 0, null, TargetTexelDensityPerMeter);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MeshMaxScreenSizePercent_Offset), 0, null, MeshMaxScreenSizePercent);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, MeshMinDrawDistance_Offset), 0, null, MeshMinDrawDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GutterSpace_Offset), 0, null, GutterSpace);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MetallicConstant_Offset), 0, null, MetallicConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RoughnessConstant_Offset), 0, null, RoughnessConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AnisotropyConstant_Offset), 0, null, AnisotropyConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpecularConstant_Offset), 0, null, SpecularConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OpacityConstant_Offset), 0, null, OpacityConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OpacityMaskConstant_Offset), 0, null, OpacityMaskConstant);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionConstant_Offset), 0, null, AmbientOcclusionConstant);
            BlittableMarshaller<UnrealSharp.Engine.EBlendMode>.ToNative(IntPtr.Add(Buffer, BlendMode_Offset), 0, null, BlendMode);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowTwoSidedMaterial_NativeProperty, bAllowTwoSidedMaterial_Offset, AllowTwoSidedMaterial);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bNormalMap_NativeProperty, bNormalMap_Offset, NormalMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bTangentMap_NativeProperty, bTangentMap_Offset, TangentMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMetallicMap_NativeProperty, bMetallicMap_Offset, MetallicMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRoughnessMap_NativeProperty, bRoughnessMap_Offset, RoughnessMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAnisotropyMap_NativeProperty, bAnisotropyMap_Offset, AnisotropyMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSpecularMap_NativeProperty, bSpecularMap_Offset, SpecularMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEmissiveMap_NativeProperty, bEmissiveMap_Offset, EmissiveMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOpacityMap_NativeProperty, bOpacityMap_Offset, OpacityMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOpacityMaskMap_NativeProperty, bOpacityMaskMap_Offset, OpacityMaskMap);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAmbientOcclusionMap_NativeProperty, bAmbientOcclusionMap_Offset, AmbientOcclusionMap);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, DiffuseTextureSize_Offset), 0, null, DiffuseTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, NormalTextureSize_Offset), 0, null, NormalTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, TangentTextureSize_Offset), 0, null, TangentTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, MetallicTextureSize_Offset), 0, null, MetallicTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, RoughnessTextureSize_Offset), 0, null, RoughnessTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, AnisotropyTextureSize_Offset), 0, null, AnisotropyTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, SpecularTextureSize_Offset), 0, null, SpecularTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, EmissiveTextureSize_Offset), 0, null, EmissiveTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, OpacityTextureSize_Offset), 0, null, OpacityTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, OpacityMaskTextureSize_Offset), 0, null, OpacityMaskTextureSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionTextureSize_Offset), 0, null, AmbientOcclusionTextureSize);
        }
    }
}

public static class MaterialProxySettingsMarshaler
{
    public static MaterialProxySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MaterialProxySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MaterialProxySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MaterialProxySettings.NativeDataSize;
    }
}