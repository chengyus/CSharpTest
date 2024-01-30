using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERayTracingGroupCullingPriority : byte
{
    CP_0_NEVER_CULL=0,
    CP_1=1,
    CP_2=2,
    CP_3=3,
    CP_4_DEFAULT=4,
    CP_5=5,
    CP_6=6,
    CP_7=7,
    CP_8_QUICKLY_CULL=8,
}