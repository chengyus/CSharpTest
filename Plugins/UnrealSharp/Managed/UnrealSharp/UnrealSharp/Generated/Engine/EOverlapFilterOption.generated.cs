using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EOverlapFilterOption : byte
{
    OverlapFilter_All=0,
    OverlapFilter_DynamicOnly=1,
    OverlapFilter_StaticOnly=2,
}