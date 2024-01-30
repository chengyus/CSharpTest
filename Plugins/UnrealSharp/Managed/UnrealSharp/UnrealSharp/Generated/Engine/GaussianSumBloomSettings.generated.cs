using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct GaussianSumBloomSettings
{
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Intensity
    public float Intensity;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Threshold
    public float Threshold;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:SizeScale
    public float SizeScale;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Filter1Size
    public float Filter1Size;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Filter2Size
    public float Filter2Size;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Filter3Size
    public float Filter3Size;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Filter4Size
    public float Filter4Size;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Filter5Size
    public float Filter5Size;
    
    // FloatProperty /Script/Engine.GaussianSumBloomSettings:Filter6Size
    public float Filter6Size;
    
    // StructProperty /Script/Engine.GaussianSumBloomSettings:Filter1Tint
    public UnrealSharp.CoreUObject.LinearColor Filter1Tint;
    
    // StructProperty /Script/Engine.GaussianSumBloomSettings:Filter2Tint
    public UnrealSharp.CoreUObject.LinearColor Filter2Tint;
    
    // StructProperty /Script/Engine.GaussianSumBloomSettings:Filter3Tint
    public UnrealSharp.CoreUObject.LinearColor Filter3Tint;
    
    // StructProperty /Script/Engine.GaussianSumBloomSettings:Filter4Tint
    public UnrealSharp.CoreUObject.LinearColor Filter4Tint;
    
    // StructProperty /Script/Engine.GaussianSumBloomSettings:Filter5Tint
    public UnrealSharp.CoreUObject.LinearColor Filter5Tint;
    
    // StructProperty /Script/Engine.GaussianSumBloomSettings:Filter6Tint
    public UnrealSharp.CoreUObject.LinearColor Filter6Tint;
    
}