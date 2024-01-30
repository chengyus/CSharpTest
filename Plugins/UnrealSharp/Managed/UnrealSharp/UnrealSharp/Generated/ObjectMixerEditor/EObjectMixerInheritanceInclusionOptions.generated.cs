using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ObjectMixerEditor;

[UEnum]
public enum EObjectMixerInheritanceInclusionOptions : byte
{
    None=0,
    IncludeOnlyImmediateParent=1,
    IncludeOnlyImmediateChildren=2,
    IncludeOnlyImmediateParentAndChildren=3,
    IncludeAllParents=4,
    IncludeAllChildren=5,
    IncludeAllParentsAndChildren=6,
    IncludeAllParentsAndOnlyImmediateChildren=7,
    IncludeOnlyImmediateParentAndAllChildren=8,
}