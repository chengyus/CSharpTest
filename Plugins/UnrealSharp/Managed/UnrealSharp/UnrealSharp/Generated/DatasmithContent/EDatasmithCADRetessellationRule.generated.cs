using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UEnum]
public enum EDatasmithCADRetessellationRule : byte
{
    All=0,
    SkipDeletedSurfaces=1,
}