using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EMaterialSearchLocation : byte
{
    Local=0,
    UnderParent=1,
    UnderRoot=2,
    AllAssets=3,
    DoNotSearch=4,
}