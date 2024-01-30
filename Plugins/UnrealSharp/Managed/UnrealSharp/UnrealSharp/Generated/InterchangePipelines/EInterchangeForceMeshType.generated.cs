using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UEnum]
public enum EInterchangeForceMeshType : byte
{
    IFMT_None=0,
    IFMT_StaticMesh=1,
    IFMT_SkeletalMesh=2,
}