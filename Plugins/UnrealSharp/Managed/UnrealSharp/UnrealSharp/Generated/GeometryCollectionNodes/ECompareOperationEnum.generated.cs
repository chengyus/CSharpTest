using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum ECompareOperationEnum : byte
{
    Dataflow_Compare_Equal=0,
    Dataflow_Compare_Smaller=1,
    Dataflow_Compare_SmallerOrEqual=2,
    Dataflow_Compare_Greater=3,
    Dataflow_Compare_GreaterOrEqual=4,
}