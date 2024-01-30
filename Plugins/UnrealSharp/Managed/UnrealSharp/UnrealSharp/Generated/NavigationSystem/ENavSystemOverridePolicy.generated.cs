using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.NavigationSystem;

[UEnum]
public enum ENavSystemOverridePolicy : byte
{
    Override=0,
    Append=1,
    Skip=2,
}