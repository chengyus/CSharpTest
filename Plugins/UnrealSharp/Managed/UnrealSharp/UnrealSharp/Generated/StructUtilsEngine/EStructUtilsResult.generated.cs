using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StructUtilsEngine;

[UEnum]
public enum EStructUtilsResult : byte
{
    Valid=0,
    NotValid=1,
}