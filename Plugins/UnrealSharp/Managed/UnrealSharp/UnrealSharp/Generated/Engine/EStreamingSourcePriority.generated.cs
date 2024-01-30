using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EStreamingSourcePriority : byte
{
    Highest=0,
    High=1,
    Normal=2,
    Low=3,
    Lowest=4,
    Default=5,
}