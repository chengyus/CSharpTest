using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UEnum]
public enum EFlipbookCollisionMode : byte
{
    NoCollision=0,
    FirstFrameCollision=1,
    EachFrameCollision=2,
}