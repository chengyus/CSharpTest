using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETextureMipLoadOptions : byte
{
    Default=0,
    AllMips=1,
    OnlyFirstMip=2,
}