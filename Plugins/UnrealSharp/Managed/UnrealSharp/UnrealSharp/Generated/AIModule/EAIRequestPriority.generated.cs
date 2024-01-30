using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EAIRequestPriority : byte
{
    SoftScript=0,
    Logic=1,
    HardScript=2,
    Reaction=3,
    Ultimate=4,
}