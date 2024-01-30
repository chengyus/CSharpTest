using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESceneCaptureCompositeMode : byte
{
    SCCM_Overwrite=0,
    SCCM_Additive=1,
    SCCM_Composite=2,
}