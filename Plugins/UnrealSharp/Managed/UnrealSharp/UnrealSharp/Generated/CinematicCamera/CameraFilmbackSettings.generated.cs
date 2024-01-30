using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct(IsBlittable = true)]
public partial struct CameraFilmbackSettings
{
    // FloatProperty /Script/CinematicCamera.CameraFilmbackSettings:SensorWidth
    public float SensorWidth;
    
    // FloatProperty /Script/CinematicCamera.CameraFilmbackSettings:SensorHeight
    public float SensorHeight;
    
    // FloatProperty /Script/CinematicCamera.CameraFilmbackSettings:SensorAspectRatio
    public float SensorAspectRatio;
    
}