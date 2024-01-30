using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum FDataDrivenCVarType : byte
{
    CVarFloat=0,
    CVarInt=1,
    CVarBool=2,
}