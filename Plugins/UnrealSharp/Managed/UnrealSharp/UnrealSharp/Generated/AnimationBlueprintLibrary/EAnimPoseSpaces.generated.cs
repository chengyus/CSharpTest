using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationBlueprintLibrary;

[UEnum]
public enum EAnimPoseSpaces : byte
{
    Local=0,
    World=1,
}