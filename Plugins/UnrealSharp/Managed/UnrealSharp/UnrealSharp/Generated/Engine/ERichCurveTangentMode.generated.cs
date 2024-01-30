using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERichCurveTangentMode : byte
{
    RCTM_Auto=0,
    RCTM_User=1,
    RCTM_Break=2,
    RCTM_SmartAuto=4,
}