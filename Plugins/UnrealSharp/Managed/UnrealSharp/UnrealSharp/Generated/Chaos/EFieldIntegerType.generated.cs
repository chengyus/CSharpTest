using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldIntegerType : byte
{
    Integer_DynamicState=0,
    Integer_ActivateDisabled=1,
    Integer_CollisionGroup=2,
}