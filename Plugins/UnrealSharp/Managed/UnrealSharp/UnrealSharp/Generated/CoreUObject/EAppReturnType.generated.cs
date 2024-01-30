using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EAppReturnType : byte
{
    No=0,
    Yes=1,
    YesAll=2,
    NoAll=3,
    Cancel=4,
    Ok=5,
    Retry=6,
    Continue=7,
}