using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldResolutionType : byte
{
    Field_Resolution_Minimal=0,
    Field_Resolution_DisabledParents=1,
    Field_Resolution_Maximum=2,
}