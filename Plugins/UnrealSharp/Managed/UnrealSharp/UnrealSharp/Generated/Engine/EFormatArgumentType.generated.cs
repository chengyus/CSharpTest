using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EFormatArgumentType : byte
{
    Int=0,
    UInt=1,
    Float=2,
    Double=3,
    Text=4,
    Gender=5,
}