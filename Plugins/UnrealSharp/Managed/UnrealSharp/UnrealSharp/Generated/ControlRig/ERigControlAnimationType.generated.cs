using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ERigControlAnimationType : byte
{
    AnimationControl=0,
    AnimationChannel=1,
    ProxyControl=2,
    VisualCue=3,
}