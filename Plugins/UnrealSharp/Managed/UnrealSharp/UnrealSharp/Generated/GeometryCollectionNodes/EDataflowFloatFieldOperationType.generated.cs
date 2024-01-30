using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EDataflowFloatFieldOperationType : byte
{
    Dataflow_FloatFieldOperationType_Multiply=0,
    Dataflow_FloatFieldFalloffType_Divide=1,
    Dataflow_FloatFieldFalloffType_Add=2,
    Dataflow_FloatFieldFalloffType_Substract=3,
    Dataflow_FloatFieldFalloffType_Min=4,
    Dataflow_FloatFieldFalloffType_Max=5,
}