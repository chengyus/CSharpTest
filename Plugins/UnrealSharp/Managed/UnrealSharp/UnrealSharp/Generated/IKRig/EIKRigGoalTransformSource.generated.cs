using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UEnum]
public enum EIKRigGoalTransformSource : byte
{
    Manual=0,
    Bone=1,
    ActorComponent=2,
}