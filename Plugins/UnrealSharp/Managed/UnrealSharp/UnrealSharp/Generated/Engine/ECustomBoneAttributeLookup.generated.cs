using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECustomBoneAttributeLookup : byte
{
    BoneOnly=0,
    ImmediateParent=1,
    ParentHierarchy=2,
}