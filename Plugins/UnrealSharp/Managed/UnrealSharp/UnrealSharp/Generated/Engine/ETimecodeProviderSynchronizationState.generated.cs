using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETimecodeProviderSynchronizationState : byte
{
    Closed=0,
    Error=1,
    Synchronized=2,
    Synchronizing=3,
}