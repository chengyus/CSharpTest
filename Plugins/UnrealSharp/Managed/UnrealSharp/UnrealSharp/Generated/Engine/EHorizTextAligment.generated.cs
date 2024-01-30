using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EHorizTextAligment : byte
{
    EHTA_Left=0,
    EHTA_Center=1,
    EHTA_Right=2,
}