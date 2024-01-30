using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EPlayerMappableKeySlot : byte
{
    First=0,
    Second=1,
    Third=2,
    Fourth=3,
    Fifth=4,
    Sixth=5,
    Seventh=6,
    Unspecified=7,
    Max=8,
}