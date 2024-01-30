using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct(IsBlittable = true)]
public partial struct CameraLensSettings
{
    // FloatProperty /Script/CinematicCamera.CameraLensSettings:MinFocalLength
    public float MinFocalLength;
    
    // FloatProperty /Script/CinematicCamera.CameraLensSettings:MaxFocalLength
    public float MaxFocalLength;
    
    // FloatProperty /Script/CinematicCamera.CameraLensSettings:MinFStop
    public float MinFStop;
    
    // FloatProperty /Script/CinematicCamera.CameraLensSettings:MaxFStop
    public float MaxFStop;
    
    // FloatProperty /Script/CinematicCamera.CameraLensSettings:MinimumFocusDistance
    public float MinimumFocusDistance;
    
    // FloatProperty /Script/CinematicCamera.CameraLensSettings:SqueezeFactor
    public float SqueezeFactor;
    
    // IntProperty /Script/CinematicCamera.CameraLensSettings:DiaphragmBladeCount
    public int DiaphragmBladeCount;
    
}