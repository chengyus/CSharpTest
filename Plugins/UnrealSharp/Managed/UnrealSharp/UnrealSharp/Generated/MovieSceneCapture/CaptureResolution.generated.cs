using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UStruct(IsBlittable = true)]
public partial struct CaptureResolution
{
    // IntProperty /Script/MovieSceneCapture.CaptureResolution:ResX
    public int ResX;
    
    // IntProperty /Script/MovieSceneCapture.CaptureResolution:ResY
    public int ResY;
    
}