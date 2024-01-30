using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum EMediaPlayerTrack : byte
{
    Audio=0,
    Caption=1,
    Metadata=2,
    Script=3,
    Subtitle=4,
    Text=5,
    Video=6,
}