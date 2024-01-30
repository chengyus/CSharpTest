using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UEnum]
public enum EDatasmithImportLightmapMax : byte
{
    LIGHTMAP_64=0,
    LIGHTMAP_128=1,
    LIGHTMAP_256=2,
    LIGHTMAP_512=3,
    LIGHTMAP_1024=4,
    LIGHTMAP_2048=5,
    LIGHTMAP_4096=6,
}