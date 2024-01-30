using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UEnum]
public enum EInterchangeTextureWrapMode : byte
{
    Wrap=0,
    Clamp=1,
    Mirror=2,
}