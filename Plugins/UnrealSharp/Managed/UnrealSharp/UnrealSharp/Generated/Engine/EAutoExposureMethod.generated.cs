using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAutoExposureMethod : byte
{
    AEM_Histogram=0,
    AEM_Basic=1,
    AEM_Manual=2,
}