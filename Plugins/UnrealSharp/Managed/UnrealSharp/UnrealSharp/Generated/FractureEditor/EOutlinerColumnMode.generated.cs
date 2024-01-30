using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FractureEditor;

[UEnum]
public enum EOutlinerColumnMode : byte
{
    State=0,
    Damage=1,
    Removal=2,
    Collision=3,
    Size=4,
}