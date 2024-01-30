using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UEnum]
public enum EEulerRotationOrder : byte
{
    XYZ=0,
    XZY=1,
    YXZ=2,
    YZX=3,
    ZXY=4,
    ZYX=5,
}