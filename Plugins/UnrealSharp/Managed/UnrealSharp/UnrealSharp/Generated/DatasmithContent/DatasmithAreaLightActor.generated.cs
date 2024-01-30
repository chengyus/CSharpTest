// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UClass]
public partial class DatasmithAreaLightActor : UnrealSharp.Engine.Actor
{
    
    static DatasmithAreaLightActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DatasmithAreaLightActor");
        
        Mobility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mobility");
        LightType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LightType");
        LightShape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LightShape");
        Dimensions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Dimensions");
        Intensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Intensity");
        IntensityUnits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IntensityUnits");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Temperature_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Temperature");
        IESTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IESTexture");
        bUseIESBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseIESBrightness");
        IESBrightnessScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IESBrightnessScale");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        SourceRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceRadius");
        SourceLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceLength");
        AttenuationRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttenuationRadius");
        SpotlightInnerAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpotlightInnerAngle");
        SpotlightOuterAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpotlightOuterAngle");
        
        
        
    }
    
    protected DatasmithAreaLightActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ByteProperty /Script/DatasmithContent.DatasmithAreaLightActor:Mobility
    static readonly int Mobility_Offset;
    
    public UnrealSharp.Engine.EComponentMobility Mobility
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.EComponentMobility>.FromNative(IntPtr.Add(NativeObject, Mobility_Offset), 0, this);
        }
    }
    
    // EnumProperty /Script/DatasmithContent.DatasmithAreaLightActor:LightType
    static readonly int LightType_Offset;
    
    public UnrealSharp.DatasmithContent.EDatasmithAreaLightActorType LightType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithAreaLightActorType>.FromNative(IntPtr.Add(NativeObject, LightType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithAreaLightActorType>.ToNative(IntPtr.Add(NativeObject, LightType_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/DatasmithContent.DatasmithAreaLightActor:LightShape
    static readonly int LightShape_Offset;
    
    public UnrealSharp.DatasmithContent.EDatasmithAreaLightActorShape LightShape
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithAreaLightActorShape>.FromNative(IntPtr.Add(NativeObject, LightShape_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithAreaLightActorShape>.ToNative(IntPtr.Add(NativeObject, LightShape_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/DatasmithContent.DatasmithAreaLightActor:Dimensions
    static readonly int Dimensions_Offset;
    
    public System.DoubleNumerics.Vector2 Dimensions
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(NativeObject, Dimensions_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(NativeObject, Dimensions_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:Intensity
    static readonly int Intensity_Offset;
    
    public float Intensity
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Intensity_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Intensity_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/DatasmithContent.DatasmithAreaLightActor:IntensityUnits
    static readonly int IntensityUnits_Offset;
    
    public UnrealSharp.Engine.ELightUnits IntensityUnits
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.ELightUnits>.FromNative(IntPtr.Add(NativeObject, IntensityUnits_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.ELightUnits>.ToNative(IntPtr.Add(NativeObject, IntensityUnits_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/DatasmithContent.DatasmithAreaLightActor:Color
    static readonly int Color_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor Color
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, Color_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(NativeObject, Color_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:Temperature
    static readonly int Temperature_Offset;
    
    public float Temperature
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Temperature_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Temperature_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/DatasmithContent.DatasmithAreaLightActor:IESTexture
    static readonly int IESTexture_Offset;
    
    public UnrealSharp.Engine.TextureLightProfile IESTexture
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.TextureLightProfile>.FromNative(IntPtr.Add(NativeObject, IESTexture_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.TextureLightProfile>.ToNative(IntPtr.Add(NativeObject, IESTexture_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/DatasmithContent.DatasmithAreaLightActor:bUseIESBrightness
    static readonly int bUseIESBrightness_Offset;
    
    public bool bUseIESBrightness
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseIESBrightness_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseIESBrightness_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:IESBrightnessScale
    static readonly int IESBrightnessScale_Offset;
    
    public float IESBrightnessScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, IESBrightnessScale_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, IESBrightnessScale_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/DatasmithContent.DatasmithAreaLightActor:Rotation
    static readonly int Rotation_Offset;
    
    public UnrealSharp.Rotator Rotation
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(NativeObject, Rotation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(NativeObject, Rotation_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:SourceRadius
    static readonly int SourceRadius_Offset;
    
    public float SourceRadius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SourceRadius_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, SourceRadius_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:SourceLength
    static readonly int SourceLength_Offset;
    
    public float SourceLength
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SourceLength_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, SourceLength_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:AttenuationRadius
    static readonly int AttenuationRadius_Offset;
    
    public float AttenuationRadius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, AttenuationRadius_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, AttenuationRadius_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:SpotlightInnerAngle
    static readonly int SpotlightInnerAngle_Offset;
    
    public float SpotlightInnerAngle
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SpotlightInnerAngle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, SpotlightInnerAngle_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/DatasmithContent.DatasmithAreaLightActor:SpotlightOuterAngle
    static readonly int SpotlightOuterAngle_Offset;
    
    public float SpotlightOuterAngle
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SpotlightOuterAngle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, SpotlightOuterAngle_Offset), 0, this, value);
        }
    }
    
    
}