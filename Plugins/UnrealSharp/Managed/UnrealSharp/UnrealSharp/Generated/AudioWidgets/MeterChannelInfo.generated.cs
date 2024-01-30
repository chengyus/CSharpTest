using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct(IsBlittable = true)]
public partial struct MeterChannelInfo
{
    // FloatProperty /Script/AudioWidgets.MeterChannelInfo:MeterValue
    public float MeterValue;
    
    // FloatProperty /Script/AudioWidgets.MeterChannelInfo:PeakValue
    public float PeakValue;
    
    // FloatProperty /Script/AudioWidgets.MeterChannelInfo:ClippingValue
    public float ClippingValue;
    
}