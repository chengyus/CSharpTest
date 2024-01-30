using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UEnum]
public enum EVirtualKeyboardType : byte
{
    Default=0,
    Number=1,
    Web=2,
    Email=3,
    Password=4,
    AlphaNumeric=5,
}