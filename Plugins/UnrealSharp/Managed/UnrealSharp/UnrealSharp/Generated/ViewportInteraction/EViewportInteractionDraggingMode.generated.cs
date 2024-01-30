using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ViewportInteraction;

[UEnum]
public enum EViewportInteractionDraggingMode : byte
{
    Nothing=0,
    TransformablesWithGizmo=1,
    TransformablesAtLaserImpact=2,
    AssistingDrag=3,
    TransformablesFreely=4,
    World=5,
    Interactable=6,
    Material=7,
}