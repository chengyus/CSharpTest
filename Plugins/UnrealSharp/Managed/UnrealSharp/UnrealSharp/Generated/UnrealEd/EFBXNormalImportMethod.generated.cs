using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFBXNormalImportMethod : byte
{
    FBXNIM_ComputeNormals=0,
    FBXNIM_ImportNormals=1,
    FBXNIM_ImportNormalsAndTangents=2,
}