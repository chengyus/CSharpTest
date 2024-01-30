using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct QuartzTransportTimeStamp
{
    // IntProperty /Script/Engine.QuartzTransportTimeStamp:Bars
    public int Bars;
    
    // IntProperty /Script/Engine.QuartzTransportTimeStamp:Beat
    public int Beat;
    
    // FloatProperty /Script/Engine.QuartzTransportTimeStamp:BeatFraction
    public float BeatFraction;
    
    // FloatProperty /Script/Engine.QuartzTransportTimeStamp:Seconds
    public float Seconds;
    
}