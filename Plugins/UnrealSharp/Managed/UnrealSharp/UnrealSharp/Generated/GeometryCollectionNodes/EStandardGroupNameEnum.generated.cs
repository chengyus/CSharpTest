using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EStandardGroupNameEnum : byte
{
    Dataflow_EStandardGroupNameEnum_Transform=0,
    Dataflow_EStandardGroupNameEnum_Geometry=1,
    Dataflow_EStandardGroupNameEnum_Faces=2,
    Dataflow_EStandardGroupNameEnum_Vertices=3,
    Dataflow_EStandardGroupNameEnum_Material=4,
    Dataflow_EStandardGroupNameEnum_Breaking=5,
    Dataflow_EStandardGroupNameEnum_Custom=6,
}