using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EPlaneConstraintAxisSetting : byte
{
    Custom=0,
    X=1,
    Y=2,
    Z=3,
    UseGlobalPhysicsSetting=4,
}