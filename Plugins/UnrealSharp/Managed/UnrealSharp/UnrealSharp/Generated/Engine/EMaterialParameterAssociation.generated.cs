using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialParameterAssociation : byte
{
    LayerParameter=0,
    BlendParameter=1,
    GlobalParameter=2,
}