using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EClusterSizeMethodEnum : byte
{
    Dataflow_ClusterSizeMethod_ByNumber=0,
    Dataflow_ClusterSizeMethod_ByFractionOfInput=1,
    Dataflow_ClusterSizeMethod_BySize=2,
    Dataflow_ClusterSizeMethod_ByGrid=3,
}