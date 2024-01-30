using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EEvaluatorMode : byte
{
    EM_Standard=0,
    EM_Freeze=1,
    EM_DelayedFreeze=2,
}