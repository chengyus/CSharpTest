using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERootMotionMode : byte
{
    NoRootMotionExtraction=0,
    IgnoreRootMotion=1,
    RootMotionFromEverything=2,
    RootMotionFromMontagesOnly=3,
}