using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationModifierLibrary;

[UEnum]
public enum EMotionExtractor_MotionType : byte
{
    Translation=1,
    Rotation=2,
    Scale=3,
    TranslationSpeed=4,
    RotationSpeed=5,
}