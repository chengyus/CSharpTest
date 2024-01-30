using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.NetCore;

[UEnum]
public enum ENetworkFailure : byte
{
    NetDriverAlreadyExists=0,
    NetDriverCreateFailure=1,
    NetDriverListenFailure=2,
    ConnectionLost=3,
    ConnectionTimeout=4,
    FailureReceived=5,
    OutdatedClient=6,
    OutdatedServer=7,
    PendingConnectionFailure=8,
    NetGuidMismatch=9,
    NetChecksumMismatch=10,
}