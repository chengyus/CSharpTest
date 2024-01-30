using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UEnum]
public enum EIKRigGoalPreviewMode : byte
{
    Additive=0,
    Absolute=1,
}