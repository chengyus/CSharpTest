using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum TextureFilter : byte
{
    TF_Nearest=0,
    TF_Bilinear=1,
    TF_Trilinear=2,
    TF_Default=3,
}