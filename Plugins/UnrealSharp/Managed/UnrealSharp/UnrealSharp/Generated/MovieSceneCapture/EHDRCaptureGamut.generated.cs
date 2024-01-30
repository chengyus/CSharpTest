using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UEnum]
public enum EHDRCaptureGamut : byte
{
    HCGM_Rec709=0,
    HCGM_P3DCI=1,
    HCGM_Rec2020=2,
    HCGM_ACES=3,
    HCGM_ACEScg=4,
    HCGM_Linear=5,
}