using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EBoneControlSpace : byte
{
    BCS_WorldSpace=0,
    BCS_ComponentSpace=1,
    BCS_ParentBoneSpace=2,
    BCS_BoneSpace=3,
}