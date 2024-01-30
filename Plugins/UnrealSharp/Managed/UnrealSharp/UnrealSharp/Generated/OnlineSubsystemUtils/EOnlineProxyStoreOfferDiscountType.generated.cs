using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystemUtils;

[UEnum]
public enum EOnlineProxyStoreOfferDiscountType : byte
{
    NotOnSale=0,
    Percentage=1,
    DiscountAmount=2,
    PayAmount=3,
}