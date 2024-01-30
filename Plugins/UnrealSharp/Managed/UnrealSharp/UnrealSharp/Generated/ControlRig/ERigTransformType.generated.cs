using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ERigTransformType : byte
{
    InitialLocal=0,
    CurrentLocal=1,
    InitialGlobal=2,
    CurrentGlobal=3,
    NumTransformTypes=4,
}