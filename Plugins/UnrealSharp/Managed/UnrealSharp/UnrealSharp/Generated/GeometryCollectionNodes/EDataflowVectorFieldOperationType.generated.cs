using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EDataflowVectorFieldOperationType : byte
{
    Dataflow_VectorFieldOperationType_Multiply=0,
    Dataflow_VectorFieldFalloffType_Divide=1,
    Dataflow_VectorFieldFalloffType_Add=2,
    Dataflow_VectorFieldFalloffType_Substract=3,
    Dataflow_VectorFieldFalloffType_CrossProduct=4,
}