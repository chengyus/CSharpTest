using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UEnum]
public enum EAnimToolBlendOperation : byte
{
    Tween=0,
    BlendToNeighbor=1,
    PushPull=2,
}