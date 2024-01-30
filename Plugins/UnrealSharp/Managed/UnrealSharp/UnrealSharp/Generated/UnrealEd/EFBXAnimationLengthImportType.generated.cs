using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFBXAnimationLengthImportType : byte
{
    FBXALIT_ExportedTime=0,
    FBXALIT_AnimatedKey=1,
    FBXALIT_SetRange=2,
}