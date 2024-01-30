using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EVisibilityBasedAnimTickOption : byte
{
    AlwaysTickPoseAndRefreshBones=0,
    AlwaysTickPose=1,
    OnlyTickMontagesWhenNotRendered=2,
    OnlyTickPoseWhenRendered=3,
}