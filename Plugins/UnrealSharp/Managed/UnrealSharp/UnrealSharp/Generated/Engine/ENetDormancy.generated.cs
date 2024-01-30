using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ENetDormancy : byte
{
    DORM_Never=0,
    DORM_Awake=1,
    DORM_DormantAll=2,
    DORM_DormantPartial=3,
    DORM_Initial=4,
}