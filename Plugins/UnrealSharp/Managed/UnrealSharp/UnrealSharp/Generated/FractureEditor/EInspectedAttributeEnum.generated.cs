using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FractureEditor;

[UEnum]
public enum EInspectedAttributeEnum : byte
{
    Volume=0,
    Level=1,
    InitialDynamicState=2,
    Size=3,
}