using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EMakeBoxDataTypeEnum : byte
{
    Dataflow_MakeBox_DataType_MinMax=0,
    Dataflow_MakeBox_DataType_CenterSize=1,
}