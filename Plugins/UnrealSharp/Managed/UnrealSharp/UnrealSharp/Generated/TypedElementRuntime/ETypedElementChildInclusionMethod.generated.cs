using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TypedElementRuntime;

[UEnum]
public enum ETypedElementChildInclusionMethod : byte
{
    None=0,
    Immediate=1,
    Recursive=2,
}