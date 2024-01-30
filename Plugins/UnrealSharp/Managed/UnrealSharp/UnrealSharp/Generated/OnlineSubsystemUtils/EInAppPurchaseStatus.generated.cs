using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystemUtils;

[UEnum]
public enum EInAppPurchaseStatus : byte
{
    Invalid=0,
    Failed=1,
    Deferred=2,
    Canceled=3,
    Purchased=4,
    Restored=5,
}