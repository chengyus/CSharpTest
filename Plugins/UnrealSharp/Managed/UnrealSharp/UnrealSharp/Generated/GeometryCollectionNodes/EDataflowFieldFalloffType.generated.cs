using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EDataflowFieldFalloffType : byte
{
    Dataflow_FieldFalloffType_None=0,
    Dataflow_FieldFalloffType_Linear=1,
    Dataflow_FieldFalloffType_Inverse=2,
    Dataflow_FieldFalloffType_Squared=3,
    Dataflow_FieldFalloffType_Logarithmic=4,
}