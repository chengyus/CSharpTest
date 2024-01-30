using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECanBeCharacterBase : byte
{
    ECB_No=0,
    ECB_Yes=1,
    ECB_Owner=2,
}