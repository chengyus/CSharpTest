using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFBXSceneNormalImportMethod : byte
{
    FBXSceneNIM_ComputeNormals=0,
    FBXSceneNIM_ImportNormals=1,
    FBXSceneNIM_ImportNormalsAndTangents=2,
}