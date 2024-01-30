using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EHorizontalAlignment : byte
{
    HAlign_Fill=0,
    HAlign_Left=1,
    HAlign_Center=2,
    HAlign_Right=3,
}