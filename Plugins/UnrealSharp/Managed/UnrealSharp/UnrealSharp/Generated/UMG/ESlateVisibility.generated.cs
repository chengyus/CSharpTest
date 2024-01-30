using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UEnum]
public enum ESlateVisibility : byte
{
    Visible=0,
    Collapsed=1,
    Hidden=2,
    HitTestInvisible=3,
    SelfHitTestInvisible=4,
}