using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationBlueprintLibrary;

[UEnum]
public enum EAnimDataEvalType : byte
{
    Source=0,
    Raw=1,
    Compressed=2,
}