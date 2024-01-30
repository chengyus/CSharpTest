using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EVerticalTextAligment : byte
{
    EVRTA_TextTop=0,
    EVRTA_TextCenter=1,
    EVRTA_TextBottom=2,
    EVRTA_QuadTop=3,
}