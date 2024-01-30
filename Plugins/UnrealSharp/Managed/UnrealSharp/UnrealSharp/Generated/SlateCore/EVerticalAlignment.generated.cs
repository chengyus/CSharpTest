using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EVerticalAlignment : byte
{
    VAlign_Fill=0,
    VAlign_Top=1,
    VAlign_Center=2,
    VAlign_Bottom=3,
}