using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UEnum]
public enum EInterchangeVertexColorImportOption : byte
{
    IVCIO_Replace=0,
    IVCIO_Ignore=1,
    IVCIO_Override=2,
}