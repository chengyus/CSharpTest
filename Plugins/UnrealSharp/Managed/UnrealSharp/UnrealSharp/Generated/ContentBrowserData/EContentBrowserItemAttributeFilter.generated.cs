using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UEnum]
public enum EContentBrowserItemAttributeFilter : byte
{
    IncludeNone=0,
    IncludeProject=1,
    IncludeEngine=2,
    IncludePlugins=3,
    IncludeDeveloper=4,
    IncludeLocalized=5,
    IncludeAll=6,
}