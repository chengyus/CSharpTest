using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EPathFollowingAction : byte
{
    Error=0,
    NoMove=1,
    DirectMove=2,
    PartialPath=3,
    PathToGoal=4,
}