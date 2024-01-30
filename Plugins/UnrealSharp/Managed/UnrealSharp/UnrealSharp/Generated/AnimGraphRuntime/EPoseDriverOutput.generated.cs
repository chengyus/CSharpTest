using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum EPoseDriverOutput : byte
{
    DrivePoses=0,
    DriveCurves=1,
}