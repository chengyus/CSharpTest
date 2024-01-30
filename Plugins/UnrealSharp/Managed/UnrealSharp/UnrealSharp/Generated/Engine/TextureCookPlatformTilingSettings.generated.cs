using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum TextureCookPlatformTilingSettings : byte
{
    TCPTS_FromTextureGroup=0,
    TCPTS_Tile=1,
    TCPTS_DoNotTile=2,
}