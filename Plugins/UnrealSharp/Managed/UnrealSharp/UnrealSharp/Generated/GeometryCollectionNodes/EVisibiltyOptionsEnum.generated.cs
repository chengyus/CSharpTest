using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EVisibiltyOptionsEnum : byte
{
    Dataflow_VisibilityOptions_Visible=0,
    Dataflow_VisibilityOptions_Invisible=1,
}