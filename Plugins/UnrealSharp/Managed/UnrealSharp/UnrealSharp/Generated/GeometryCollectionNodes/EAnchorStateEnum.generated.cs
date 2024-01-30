using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EAnchorStateEnum : byte
{
    Dataflow_AnchorState_Anchored=0,
    Dataflow_AnchorState_NotAnchored=1,
}