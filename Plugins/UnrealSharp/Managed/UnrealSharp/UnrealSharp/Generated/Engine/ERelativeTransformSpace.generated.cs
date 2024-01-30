using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERelativeTransformSpace : byte
{
    RTS_World=0,
    RTS_Actor=1,
    RTS_Component=2,
    RTS_ParentBoneSpace=3,
}