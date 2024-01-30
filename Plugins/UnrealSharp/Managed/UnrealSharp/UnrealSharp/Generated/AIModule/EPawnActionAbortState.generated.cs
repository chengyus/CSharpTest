using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EPawnActionAbortState : byte
{
    NeverStarted=0,
    NotBeingAborted=1,
    MarkPendingAbort=2,
    LatentAbortInProgress=3,
    AbortDone=4,
}