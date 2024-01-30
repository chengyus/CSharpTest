using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ProceduralMeshComponent;

[UEnum]
public enum EProcMeshSliceCapOption : byte
{
    NoCap=0,
    CreateNewSectionForCap=1,
    UseLastSectionForCap=2,
}