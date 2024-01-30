using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UEnum]
public enum EDatasmithAreaLightActorShape : byte
{
    Rectangle=0,
    Disc=1,
    Sphere=2,
    Cylinder=3,
    None=4,
}