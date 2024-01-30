using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAnimationMode : byte
{
    AnimationBlueprint=0,
    AnimationSingleNode=1,
    AnimationCustomMode=2,
}