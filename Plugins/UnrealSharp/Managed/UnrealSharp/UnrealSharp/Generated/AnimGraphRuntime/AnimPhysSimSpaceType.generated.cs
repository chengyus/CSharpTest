using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum AnimPhysSimSpaceType : byte
{
    Component=0,
    Actor=1,
    World=2,
    RootRelative=3,
    BoneRelative=4,
}