using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETexturePowerOfTwoSetting : byte
{
    None=0,
    PadToPowerOfTwo=1,
    PadToSquarePowerOfTwo=2,
}