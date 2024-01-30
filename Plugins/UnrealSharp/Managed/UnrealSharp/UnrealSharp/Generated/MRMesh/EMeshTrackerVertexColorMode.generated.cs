using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MRMesh;

[UEnum]
public enum EMeshTrackerVertexColorMode : byte
{
    None=0,
    Confidence=1,
    Block=2,
}