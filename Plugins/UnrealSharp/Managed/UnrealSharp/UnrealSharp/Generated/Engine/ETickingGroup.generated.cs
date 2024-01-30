using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETickingGroup : byte
{
    TG_PrePhysics=0,
    TG_DuringPhysics=2,
    TG_PostPhysics=4,
    TG_PostUpdateWork=5,
}