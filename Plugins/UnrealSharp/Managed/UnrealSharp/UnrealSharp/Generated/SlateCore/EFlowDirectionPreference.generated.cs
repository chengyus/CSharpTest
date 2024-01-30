using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EFlowDirectionPreference : byte
{
    Inherit=0,
    Culture=1,
    LeftToRight=2,
    RightToLeft=3,
}