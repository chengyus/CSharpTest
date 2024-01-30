using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialDomain : byte
{
    MD_Surface=0,
    MD_DeferredDecal=1,
    MD_LightFunction=2,
    MD_Volume=3,
    MD_PostProcess=4,
    MD_UI=5,
}