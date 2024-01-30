using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeCore;

[UEnum]
public enum EInterchangeTranslatorType : byte
{
    Invalid=0,
    Assets=1,
    Actors=2,
    Scenes=3,
}