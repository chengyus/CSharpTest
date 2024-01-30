using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PBIK;

[UEnum]
public enum EPBIKLimitType : byte
{
    Free=0,
    Limited=1,
    Locked=2,
}