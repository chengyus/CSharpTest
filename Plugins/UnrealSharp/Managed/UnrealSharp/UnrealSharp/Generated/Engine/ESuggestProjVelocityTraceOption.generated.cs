using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESuggestProjVelocityTraceOption : byte
{
    DoNotTrace=0,
    TraceFullPath=1,
    OnlyTraceWhileAscending=2,
}