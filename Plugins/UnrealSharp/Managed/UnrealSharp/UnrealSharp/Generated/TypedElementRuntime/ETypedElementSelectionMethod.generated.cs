using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TypedElementRuntime;

[UEnum]
public enum ETypedElementSelectionMethod : byte
{
    Primary=0,
    Secondary=1,
}