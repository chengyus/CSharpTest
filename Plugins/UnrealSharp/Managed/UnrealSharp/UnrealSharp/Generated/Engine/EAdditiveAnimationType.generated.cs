using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAdditiveAnimationType : byte
{
    AAT_None=0,
    AAT_LocalSpaceBase=1,
    AAT_RotationOffsetMeshSpace=2,
}