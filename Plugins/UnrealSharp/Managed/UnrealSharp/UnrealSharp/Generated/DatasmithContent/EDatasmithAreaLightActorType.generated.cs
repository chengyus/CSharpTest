using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UEnum]
public enum EDatasmithAreaLightActorType : byte
{
    Point=0,
    Spot=1,
    IES_DEPRECATED=2,
    Rect=3,
}