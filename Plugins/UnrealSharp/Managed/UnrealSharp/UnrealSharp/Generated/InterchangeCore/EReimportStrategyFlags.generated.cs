using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeCore;

[UEnum]
public enum EReimportStrategyFlags : byte
{
    ApplyNoProperties=0,
    ApplyPipelineProperties=1,
    ApplyEditorChangedProperties=2,
}