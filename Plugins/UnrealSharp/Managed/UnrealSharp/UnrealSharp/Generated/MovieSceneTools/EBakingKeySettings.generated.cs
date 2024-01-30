using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UEnum]
public enum EBakingKeySettings : byte
{
    KeysOnly=0,
    AllFrames=1,
}