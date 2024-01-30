using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum EMovieSceneControlRigSpaceType : byte
{
    Parent=0,
    World=1,
    ControlRig=2,
}