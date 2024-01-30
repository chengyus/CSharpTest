using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FractureEditor;

[UEnum]
public enum EDynamicStateOverrideEnum : byte
{
    NoOverride=0,
    Sleeping=1,
    Kinematic=2,
    Static=3,
}