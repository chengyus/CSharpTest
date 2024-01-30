using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EStatisticsOperationEnum : byte
{
    Dataflow_EStatisticsOperationEnum_Min=0,
    Dataflow_EStatisticsOperationEnum_Max=1,
    Dataflow_EStatisticsOperationEnum_Mean=2,
    Dataflow_EStatisticsOperationEnum_Median=3,
    Dataflow_EStatisticsOperationEnum_Mode=4,
    Dataflow_EStatisticsOperationEnum_Sum=5,
}