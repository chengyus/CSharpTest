using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECompositeTextureMode : byte
{
    CTM_Disabled=0,
    CTM_NormalRoughnessToRed=1,
    CTM_NormalRoughnessToGreen=2,
    CTM_NormalRoughnessToBlue=3,
    CTM_NormalRoughnessToAlpha=4,
}