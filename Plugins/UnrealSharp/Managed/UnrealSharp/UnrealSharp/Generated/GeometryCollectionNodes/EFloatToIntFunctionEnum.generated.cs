using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EFloatToIntFunctionEnum : byte
{
    Dataflow_FloatToInt_Function_Floor=0,
    Dataflow_FloatToInt_Function_Ceil=1,
    Dataflow_FloatToInt_Function_Round=2,
    Dataflow_FloatToInt_Function_Truncate=3,
}