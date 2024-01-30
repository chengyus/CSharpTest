using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAnimGroupRole : byte
{
    CanBeLeader=0,
    AlwaysFollower=1,
    AlwaysLeader=2,
    TransitionLeader=3,
    TransitionFollower=4,
}