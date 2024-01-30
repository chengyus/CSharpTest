using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UEnum]
public enum ESlateAccessibleBehavior : byte
{
    NotAccessible=0,
    Auto=1,
    Summary=2,
    Custom=3,
    ToolTip=4,
}