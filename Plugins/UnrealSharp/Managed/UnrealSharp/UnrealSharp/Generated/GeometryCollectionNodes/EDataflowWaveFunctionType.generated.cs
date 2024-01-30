using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EDataflowWaveFunctionType : byte
{
    Dataflow_WaveFunctionType_Cosine=0,
    Dataflow_WaveFunctionType_Gaussian=1,
    Dataflow_WaveFunctionType_Falloff=2,
    Dataflow_WaveFunctionType_Decay=3,
}