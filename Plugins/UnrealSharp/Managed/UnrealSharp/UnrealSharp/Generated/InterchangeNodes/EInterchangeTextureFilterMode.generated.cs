using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UEnum]
public enum EInterchangeTextureFilterMode : byte
{
    Nearest=0,
    Bilinear=1,
    Trilinear=2,
    Default=3,
}