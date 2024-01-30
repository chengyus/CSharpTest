using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum EControlRigComponentSpace : byte
{
    WorldSpace=0,
    ActorSpace=1,
    ComponentSpace=2,
    RigSpace=3,
    LocalSpace=4,
}