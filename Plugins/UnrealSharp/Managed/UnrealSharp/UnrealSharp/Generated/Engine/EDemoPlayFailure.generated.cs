using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EDemoPlayFailure : byte
{
    Generic=0,
    DemoNotFound=1,
    Corrupt=2,
    InvalidVersion=3,
    InitBase=4,
    GameSpecificHeader=5,
    ReplayStreamerInternal=6,
    LoadMap=7,
    Serialization=8,
}