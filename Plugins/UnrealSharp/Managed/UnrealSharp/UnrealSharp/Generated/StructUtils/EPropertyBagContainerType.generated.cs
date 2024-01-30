using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StructUtils;

[UEnum]
public enum EPropertyBagContainerType : byte
{
    None=0,
    Array=1,
}