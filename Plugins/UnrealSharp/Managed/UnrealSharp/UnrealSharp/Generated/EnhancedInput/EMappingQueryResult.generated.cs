using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EMappingQueryResult : byte
{
    Error_EnhancedInputNotEnabled=0,
    Error_InputContextNotInActiveContexts=1,
    Error_InvalidAction=2,
    NotMappable=3,
    MappingAvailable=4,
}