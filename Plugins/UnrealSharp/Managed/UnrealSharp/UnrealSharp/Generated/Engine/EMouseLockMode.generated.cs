using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMouseLockMode : byte
{
    DoNotLock=0,
    LockOnCapture=1,
    LockAlways=2,
    LockInFullscreen=3,
}