using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EObjectStateTypeEnum : byte
{
    Chaos_Object_Sleeping=1,
    Chaos_Object_Kinematic=2,
    Chaos_Object_Static=3,
    Chaos_Object_Dynamic=4,
    Chaos_Object_UserDefined=5,
}