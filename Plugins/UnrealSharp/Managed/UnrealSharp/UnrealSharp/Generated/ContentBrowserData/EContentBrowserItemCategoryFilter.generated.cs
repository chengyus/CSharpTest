using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ContentBrowserData;

[UEnum]
public enum EContentBrowserItemCategoryFilter : byte
{
    IncludeNone=0,
    IncludeAssets=1,
    IncludeClasses=2,
    IncludeCollections=3,
    IncludeMisc=4,
    IncludeAll=5,
}