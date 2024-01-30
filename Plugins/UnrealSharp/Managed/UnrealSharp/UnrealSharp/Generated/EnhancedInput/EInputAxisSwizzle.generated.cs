using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EInputAxisSwizzle : byte
{
    YXZ=0,
    ZYX=1,
    XZY=2,
    YZX=3,
    ZXY=4,
}