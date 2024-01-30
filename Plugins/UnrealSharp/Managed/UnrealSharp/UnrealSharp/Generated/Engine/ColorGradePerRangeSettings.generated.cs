using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct ColorGradePerRangeSettings
{
    // StructProperty /Script/Engine.ColorGradePerRangeSettings:Saturation
    public System.DoubleNumerics.Vector4 Saturation;
    
    // StructProperty /Script/Engine.ColorGradePerRangeSettings:Contrast
    public System.DoubleNumerics.Vector4 Contrast;
    
    // StructProperty /Script/Engine.ColorGradePerRangeSettings:Gamma
    public System.DoubleNumerics.Vector4 Gamma;
    
    // StructProperty /Script/Engine.ColorGradePerRangeSettings:Gain
    public System.DoubleNumerics.Vector4 Gain;
    
    // StructProperty /Script/Engine.ColorGradePerRangeSettings:Offset
    public System.DoubleNumerics.Vector4 Offset;
    
}