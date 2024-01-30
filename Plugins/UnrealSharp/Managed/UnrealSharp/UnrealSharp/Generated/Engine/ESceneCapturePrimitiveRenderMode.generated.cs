using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESceneCapturePrimitiveRenderMode : byte
{
    PRM_LegacySceneCapture=0,
    PRM_RenderScenePrimitives=1,
    PRM_UseShowOnlyList=2,
}