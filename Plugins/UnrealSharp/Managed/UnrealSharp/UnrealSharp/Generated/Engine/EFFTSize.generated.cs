using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EFFTSize : byte
{
    DefaultSize=0,
    Min=1,
    Small=2,
    Medium=3,
    Large=4,
    VeryLarge=5,
    Max=6,
}