using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UEnum]
public enum EConstantQFFTSizeEnum : byte
{
    Min=0,
    XXSmall=1,
    XSmall=2,
    Small=3,
    Medium=4,
    Large=5,
    XLarge=6,
    XXLarge=7,
    Max=8,
}