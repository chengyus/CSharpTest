using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESpawnActorCollisionHandlingMethod : byte
{
    Undefined=0,
    AlwaysSpawn=1,
    AdjustIfPossibleButAlwaysSpawn=2,
    AdjustIfPossibleButDontSpawnIfColliding=3,
    DontSpawnIfColliding=4,
}