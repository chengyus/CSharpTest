using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFBXImportContentType : byte
{
    FBXICT_All=0,
    FBXICT_Geometry=1,
    FBXICT_SkinningWeights=2,
}