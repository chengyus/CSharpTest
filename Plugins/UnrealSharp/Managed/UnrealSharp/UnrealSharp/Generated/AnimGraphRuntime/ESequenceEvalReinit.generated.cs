using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum ESequenceEvalReinit : byte
{
    NoReset=0,
    StartPosition=1,
    ExplicitTime=2,
}