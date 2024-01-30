using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldCullingOperationType : byte
{
    Field_Culling_Inside=0,
    Field_Culling_Outside=1,
}