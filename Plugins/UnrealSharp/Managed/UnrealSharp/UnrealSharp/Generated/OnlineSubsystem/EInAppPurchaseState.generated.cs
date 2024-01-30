using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystem;

[UEnum]
public enum EInAppPurchaseState : byte
{
    Unknown=0,
    Success=1,
    Failed=2,
    Cancelled=3,
    Invalid=4,
    NotAllowed=5,
    Restored=6,
    AlreadyOwned=7,
}