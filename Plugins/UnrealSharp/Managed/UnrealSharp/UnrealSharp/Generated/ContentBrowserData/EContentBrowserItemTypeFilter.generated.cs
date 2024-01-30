using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UEnum]
public enum EContentBrowserItemTypeFilter : byte
{
    IncludeNone=0,
    IncludeFolders=1,
    IncludeFiles=2,
    IncludeAll=3,
}