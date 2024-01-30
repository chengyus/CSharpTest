using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UEnum]
public enum FControlRigChannelEnum : byte
{
    Bool=0,
    Enum=1,
    Integer=2,
    Float=3,
    Vector2DX=4,
    Vector2DY=5,
    PositionX=6,
    PositionY=7,
    PositionZ=8,
    RotatorX=9,
    RotatorY=10,
    RotatorZ=11,
    ScaleX=12,
    ScaleY=13,
    ScaleZ=14,
}