using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EDataflowSetMaskConditionType : byte
{
    Dataflow_SetMaskConditionType_Always=0,
    Dataflow_SetMaskConditionType_IFF_NOT_Interior=1,
    Dataflow_SetMaskConditionType_IFF_NOT_Exterior=2,
}