using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RegionScaleFactors
{
    // FloatProperty /Script/ControlRig.RegionScaleFactors:PositiveWidth
    public float PositiveWidth;
    
    // FloatProperty /Script/ControlRig.RegionScaleFactors:NegativeWidth
    public float NegativeWidth;
    
    // FloatProperty /Script/ControlRig.RegionScaleFactors:PositiveHeight
    public float PositiveHeight;
    
    // FloatProperty /Script/ControlRig.RegionScaleFactors:NegativeHeight
    public float NegativeHeight;
    
}