using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UEnum]
public enum ECollisionTraceFlag : byte
{
    CTF_UseDefault=0,
    CTF_UseSimpleAndComplex=1,
    CTF_UseSimpleAsComplex=2,
    CTF_UseComplexAsSimple=3,
}