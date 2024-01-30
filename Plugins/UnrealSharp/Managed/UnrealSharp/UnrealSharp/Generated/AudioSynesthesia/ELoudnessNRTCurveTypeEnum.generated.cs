using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UEnum]
public enum ELoudnessNRTCurveTypeEnum : byte
{
    A=0,
    B=1,
    C=2,
    D=3,
    None=4,
}