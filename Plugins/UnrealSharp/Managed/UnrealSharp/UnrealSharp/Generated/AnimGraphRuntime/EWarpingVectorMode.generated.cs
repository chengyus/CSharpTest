using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum EWarpingVectorMode : byte
{
    ComponentSpaceVector=0,
    ActorSpaceVector=1,
    WorldSpaceVector=2,
    IKFootRootLocalSpaceVector=3,
}