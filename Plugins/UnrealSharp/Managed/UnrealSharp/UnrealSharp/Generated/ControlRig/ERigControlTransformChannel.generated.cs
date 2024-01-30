using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ERigControlTransformChannel : byte
{
    TranslationX=0,
    TranslationY=1,
    TranslationZ=2,
    Pitch=3,
    Yaw=4,
    Roll=5,
    ScaleX=6,
    ScaleY=7,
    ScaleZ=8,
}