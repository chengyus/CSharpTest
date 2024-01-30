using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UEnum]
public enum EDatasmithImportLightmapMin : byte
{
    LIGHTMAP_16=0,
    LIGHTMAP_32=1,
    LIGHTMAP_64=2,
    LIGHTMAP_128=3,
    LIGHTMAP_256=4,
    LIGHTMAP_512=5,
}