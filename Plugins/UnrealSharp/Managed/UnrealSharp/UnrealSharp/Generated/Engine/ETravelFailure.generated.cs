using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETravelFailure : byte
{
    NoLevel=0,
    LoadMapFailure=1,
    InvalidURL=2,
    PackageMissing=3,
    PackageVersion=4,
    NoDownload=5,
    TravelFailure=6,
    CheatCommands=7,
    PendingNetGameCreateFailure=8,
    CloudSaveFailure=9,
    ServerTravelFailure=10,
    ClientTravelFailure=11,
}