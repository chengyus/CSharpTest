using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMirrorRowType : byte
{
    Bone=0,
    AnimationNotify=1,
    Curve=2,
    SyncMarker=3,
    Custom=4,
}