using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EInputEvent : byte
{
    IE_Pressed=0,
    IE_Released=1,
    IE_Repeat=2,
    IE_DoubleClick=3,
    IE_Axis=4,
}