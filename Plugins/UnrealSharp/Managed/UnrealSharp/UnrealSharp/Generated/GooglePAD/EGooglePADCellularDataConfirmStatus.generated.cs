using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GooglePAD;

[UEnum]
public enum EGooglePADCellularDataConfirmStatus : byte
{
    AssetPack_CONFIRM_UNKNOWN=0,
    AssetPack_CONFIRM_PENDING=1,
    AssetPack_CONFIRM_USER_APPROVED=2,
    AssetPack_CONFIRM_USER_CANCELED=3,
}