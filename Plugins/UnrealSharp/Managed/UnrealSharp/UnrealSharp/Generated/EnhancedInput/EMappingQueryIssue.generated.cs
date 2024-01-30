using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EMappingQueryIssue : byte
{
    NoIssue=0,
    ReservedByAction=1,
    HidesExistingMapping=2,
    HiddenByExistingMapping=3,
    CollisionWithMappingInSameContext=4,
    ForcesTypePromotion=5,
    ForcesTypeDemotion=6,
}