using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum MediaTextureOrientation : byte
{
    MTORI_Original=0,
    MTORI_CW90=1,
    MTORI_CW180=2,
    MTORI_CW270=3,
}