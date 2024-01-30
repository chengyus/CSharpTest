using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EInputActionValueType : byte
{
    Boolean=0,
    Axis1D=1,
    Axis2D=2,
    Axis3D=3,
}