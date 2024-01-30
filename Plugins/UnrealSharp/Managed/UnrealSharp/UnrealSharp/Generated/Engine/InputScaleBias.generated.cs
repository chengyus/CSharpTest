using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct InputScaleBias
{
    // FloatProperty /Script/Engine.InputScaleBias:Scale
    public float Scale;
    
    // FloatProperty /Script/Engine.InputScaleBias:Bias
    public float Bias;
    
}