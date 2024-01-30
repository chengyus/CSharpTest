using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum ESetOperationEnum : byte
{
    Dataflow_SetOperation_AND=0,
    Dataflow_SetOperation_OR=1,
    Dataflow_SetOperation_XOR=2,
}