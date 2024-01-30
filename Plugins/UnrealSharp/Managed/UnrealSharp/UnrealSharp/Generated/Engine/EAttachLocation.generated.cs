using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAttachLocation : byte
{
    KeepRelativeOffset=0,
    KeepWorldPosition=1,
    SnapToTarget=2,
    SnapToTargetIncludingScale=3,
}