using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UEnum]
public enum EDynamicMeshComponentTangentsMode : byte
{
    NoTangents=0,
    AutoCalculated=1,
    ExternallyProvided=2,
    Default=3,
}