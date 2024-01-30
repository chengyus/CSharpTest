using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum ESwapRootBone : byte
{
    SwapRootBone_Component=0,
    SwapRootBone_Actor=1,
    SwapRootBone_None=2,
}