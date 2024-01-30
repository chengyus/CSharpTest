using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum EBoneModificationMode : byte
{
    BMM_Ignore=0,
    BMM_Replace=1,
    BMM_Additive=2,
}