using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct(IsBlittable = true)]
public partial struct PlateCropSettings
{
    // FloatProperty /Script/CinematicCamera.PlateCropSettings:AspectRatio
    public float AspectRatio;
    
}