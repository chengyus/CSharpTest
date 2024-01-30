using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EWorldPartitionRuntimeCellState : byte
{
    Unloaded=0,
    Loaded=1,
    Activated=2,
}