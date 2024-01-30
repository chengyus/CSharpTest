using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LocationServicesBPLibrary;

[UEnum]
public enum ELocationAccuracy : byte
{
    LA_ThreeKilometers=0,
    LA_OneKilometer=1,
    LA_HundredMeters=2,
    LA_TenMeters=3,
    LA_Best=4,
    LA_Navigation=5,
}