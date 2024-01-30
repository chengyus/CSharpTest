using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeFactoryNodes;

[UEnum]
public enum EInterchangeSkeletalMeshContentType : byte
{
    All=0,
    Geometry=1,
    SkinningWeights=2,
}