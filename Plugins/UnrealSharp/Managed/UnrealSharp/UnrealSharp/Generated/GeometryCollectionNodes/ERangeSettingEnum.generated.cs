using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum ERangeSettingEnum : byte
{
    Dataflow_RangeSetting_InsideRange=0,
    Dataflow_RangeSetting_OutsideRange=1,
}