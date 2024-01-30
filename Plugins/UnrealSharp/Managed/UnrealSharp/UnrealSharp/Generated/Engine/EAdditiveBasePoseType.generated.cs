using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAdditiveBasePoseType : byte
{
    ABPT_None=0,
    ABPT_RefPose=1,
    ABPT_AnimScaled=2,
    ABPT_AnimFrame=3,
    ABPT_LocalAnimFrame=4,
}