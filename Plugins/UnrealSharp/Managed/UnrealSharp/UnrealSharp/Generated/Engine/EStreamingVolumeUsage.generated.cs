using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EStreamingVolumeUsage : byte
{
    SVB_Loading=0,
    SVB_LoadingAndVisibility=1,
    SVB_VisibilityBlockingOnLoad=2,
    SVB_BlockingOnLoad=3,
    SVB_LoadingNotVisible=4,
}