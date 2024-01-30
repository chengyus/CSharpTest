using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UEnum]
public enum ECastToControlRigBlueprintCases : byte
{
    CastSucceeded=0,
    CastFailed=1,
}