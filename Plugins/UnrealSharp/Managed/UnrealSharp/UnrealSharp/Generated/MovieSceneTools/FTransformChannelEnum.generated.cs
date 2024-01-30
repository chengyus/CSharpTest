using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UEnum]
public enum FTransformChannelEnum : byte
{
    TranslateX=0,
    TranslateY=1,
    TranslateZ=2,
    RotateX=3,
    RotateY=4,
    RotateZ=5,
    ScaleX=6,
    ScaleY=7,
    ScaleZ=8,
}