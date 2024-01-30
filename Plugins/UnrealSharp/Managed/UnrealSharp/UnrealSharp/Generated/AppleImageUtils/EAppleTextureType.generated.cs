using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AppleImageUtils;

[UEnum]
public enum EAppleTextureType : byte
{
    Unknown=0,
    Image=1,
    PixelBuffer=2,
    Surface=3,
    MetalTexture=4,
}