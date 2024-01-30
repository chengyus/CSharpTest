using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Landscape;

[UEnum]
public enum ELandscapeToolTargetType : byte
{
    Heightmap=0,
    Weightmap=1,
    Visibility=2,
}