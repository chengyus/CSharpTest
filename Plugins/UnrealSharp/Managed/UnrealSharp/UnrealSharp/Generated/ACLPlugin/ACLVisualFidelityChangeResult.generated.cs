using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ACLPlugin;

[UEnum]
public enum ACLVisualFidelityChangeResult : byte
{
    Dispatched=0,
    Completed=1,
    Failed=2,
}