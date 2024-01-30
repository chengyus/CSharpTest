using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETransitionRequestOverwriteMode : byte
{
    Append=0,
    Ignore=1,
    Overwrite=2,
}