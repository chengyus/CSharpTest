using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UEnum]
public enum EContentBrowserPathType : byte
{
    None=0,
    Internal=1,
    Virtual=2,
}