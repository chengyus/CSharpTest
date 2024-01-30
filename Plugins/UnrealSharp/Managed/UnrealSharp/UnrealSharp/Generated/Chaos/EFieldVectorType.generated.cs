using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldVectorType : byte
{
    Vector_LinearForce=0,
    Vector_LinearVelocity=1,
    Vector_AngularVelocity=2,
    Vector_AngularTorque=3,
}