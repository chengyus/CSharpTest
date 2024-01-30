using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum TextureAddress : byte
{
    TA_Wrap=0,
    TA_Clamp=1,
    TA_Mirror=2,
}