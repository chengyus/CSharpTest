using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EDamageModelTypeEnum : byte
{
    Chaos_Damage_Model_UserDefined_Damage_Threshold=0,
    Chaos_Damage_Model_Material_Strength_And_Connectivity_DamageThreshold=1,
}