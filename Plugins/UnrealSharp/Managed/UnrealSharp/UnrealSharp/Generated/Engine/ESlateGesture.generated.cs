using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESlateGesture : byte
{
    None=0,
    Scroll=1,
    Magnify=2,
    Swipe=3,
    Rotate=4,
    LongPress=5,
}