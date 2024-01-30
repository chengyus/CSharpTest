using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum ETextCommit : byte
{
    Default=0,
    OnEnter=1,
    OnUserMovedFocus=2,
    OnCleared=3,
}