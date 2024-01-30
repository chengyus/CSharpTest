using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UStruct(IsBlittable = true)]
public partial struct FrameMetrics
{
    // FloatProperty /Script/MovieSceneCapture.FrameMetrics:TotalElapsedTime
    public float TotalElapsedTime;
    
    // FloatProperty /Script/MovieSceneCapture.FrameMetrics:FrameDelta
    public float FrameDelta;
    
    // IntProperty /Script/MovieSceneCapture.FrameMetrics:FrameNumber
    public int FrameNumber;
    
    // IntProperty /Script/MovieSceneCapture.FrameMetrics:NumDroppedFrames
    public int NumDroppedFrames;
    
}