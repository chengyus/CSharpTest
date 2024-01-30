using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFbxSceneVertexColorImportOption : byte
{
    Replace=0,
    Ignore=1,
    Override=2,
}