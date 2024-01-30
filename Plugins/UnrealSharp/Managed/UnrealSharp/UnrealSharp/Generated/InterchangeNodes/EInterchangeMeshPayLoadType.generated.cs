using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UEnum]
public enum EInterchangeMeshPayLoadType : byte
{
    NONE=0,
    STATIC=1,
    SKELETAL=2,
    MORPHTARGET=3,
}