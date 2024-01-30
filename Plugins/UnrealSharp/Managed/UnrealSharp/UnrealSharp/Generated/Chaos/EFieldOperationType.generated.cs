using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldOperationType : byte
{
    Field_Multiply=0,
    Field_Divide=1,
    Field_Add=2,
    Field_Substract=3,
}