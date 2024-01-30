using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERigVMClampSpatialMode : byte
{
    Plane=0,
    Cylinder=1,
    Sphere=2,
}