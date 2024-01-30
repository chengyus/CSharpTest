using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFBXImportType : byte
{
    FBXIT_StaticMesh=0,
    FBXIT_SkeletalMesh=1,
    FBXIT_Animation=2,
}