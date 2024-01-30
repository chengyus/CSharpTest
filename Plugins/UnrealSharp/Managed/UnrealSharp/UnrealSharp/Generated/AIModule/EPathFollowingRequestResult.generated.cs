using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EPathFollowingRequestResult : byte
{
    Failed=0,
    AlreadyAtGoal=1,
    RequestSuccessful=2,
}