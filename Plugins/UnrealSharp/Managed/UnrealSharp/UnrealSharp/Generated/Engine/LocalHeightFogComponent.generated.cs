// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class LocalHeightFogComponent : UnrealSharp.Engine.SceneComponent
{
    
    static LocalHeightFogComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("LocalHeightFogComponent");
        
        FogMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogMode");
        FogDensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogDensity");
        FogHeightFalloff_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogHeightFalloff");
        FogHeightOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogHeightOffset");
        FogRadialAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogRadialAttenuation");
        FogPhaseG_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogPhaseG");
        FogAlbedo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogAlbedo");
        FogEmissive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogEmissive");
        FogSortPriority_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FogSortPriority");
        
        
        
    }
    
    protected LocalHeightFogComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // EnumProperty /Script/Engine.LocalHeightFogComponent:FogMode
    static readonly int FogMode_Offset;
    
    public UnrealSharp.Engine.ELocalFogMode FogMode
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.ELocalFogMode>.FromNative(IntPtr.Add(NativeObject, FogMode_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.LocalHeightFogComponent:FogDensity
    static readonly int FogDensity_Offset;
    
    public float FogDensity
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FogDensity_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.LocalHeightFogComponent:FogHeightFalloff
    static readonly int FogHeightFalloff_Offset;
    
    public float FogHeightFalloff
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FogHeightFalloff_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.LocalHeightFogComponent:FogHeightOffset
    static readonly int FogHeightOffset_Offset;
    
    public float FogHeightOffset
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FogHeightOffset_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.LocalHeightFogComponent:FogRadialAttenuation
    static readonly int FogRadialAttenuation_Offset;
    
    public float FogRadialAttenuation
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FogRadialAttenuation_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.LocalHeightFogComponent:FogPhaseG
    static readonly int FogPhaseG_Offset;
    
    public float FogPhaseG
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FogPhaseG_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.LocalHeightFogComponent:FogAlbedo
    static readonly int FogAlbedo_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor FogAlbedo
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, FogAlbedo_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.LocalHeightFogComponent:FogEmissive
    static readonly int FogEmissive_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor FogEmissive
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, FogEmissive_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Engine.LocalHeightFogComponent:FogSortPriority
    static readonly int FogSortPriority_Offset;
    
    public int FogSortPriority
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, FogSortPriority_Offset), 0, this);
        }
    }
    
    
}