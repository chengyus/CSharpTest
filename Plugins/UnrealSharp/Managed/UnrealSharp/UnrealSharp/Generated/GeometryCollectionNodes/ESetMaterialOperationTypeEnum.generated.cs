using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum ESetMaterialOperationTypeEnum : byte
{
    Dataflow_SetMaterialOperationType_Add=0,
    Dataflow_SetMaterialOperationType_Insert=1,
}