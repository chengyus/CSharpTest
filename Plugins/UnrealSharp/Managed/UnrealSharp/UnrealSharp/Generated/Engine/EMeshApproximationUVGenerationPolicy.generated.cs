using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMeshApproximationUVGenerationPolicy : byte
{
    PreferUVAtlas=0,
    PreferXAtlas=1,
    PreferPatchBuilder=2,
}