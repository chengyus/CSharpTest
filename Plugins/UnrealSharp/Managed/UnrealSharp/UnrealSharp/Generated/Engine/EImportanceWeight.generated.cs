using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EImportanceWeight : byte
{
    Luminance=0,
    Red=1,
    Green=2,
    Blue=3,
    Alpha=4,
}