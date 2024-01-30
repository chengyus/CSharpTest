using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERefractionMode : byte
{
    RM_IndexOfRefraction=0,
    RM_PixelNormalOffset=1,
    RM_2DOffset=2,
    RM_None=3,
}