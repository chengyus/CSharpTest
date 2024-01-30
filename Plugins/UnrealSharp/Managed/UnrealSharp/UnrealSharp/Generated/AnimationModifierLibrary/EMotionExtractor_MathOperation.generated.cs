using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationModifierLibrary;

[UEnum]
public enum EMotionExtractor_MathOperation : byte
{
    None=0,
    Addition=1,
    Subtraction=2,
    Division=3,
    Multiplication=4,
}