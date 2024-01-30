using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum ESetMaskConditionType : byte
{
    Field_Set_Always=0,
    Field_Set_IFF_NOT_Interior=1,
    Field_Set_IFF_NOT_Exterior=2,
}