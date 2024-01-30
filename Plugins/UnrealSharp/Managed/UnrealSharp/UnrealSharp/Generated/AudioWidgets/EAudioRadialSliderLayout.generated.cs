using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UEnum]
public enum EAudioRadialSliderLayout : byte
{
    Layout_LabelTop=0,
    Layout_LabelCenter=1,
    Layout_LabelBottom=2,
}