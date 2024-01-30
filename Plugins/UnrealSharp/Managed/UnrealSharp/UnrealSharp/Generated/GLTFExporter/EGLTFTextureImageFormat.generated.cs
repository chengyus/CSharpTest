using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UEnum]
public enum EGLTFTextureImageFormat : byte
{
    None=0,
    PNG=1,
    JPEG=2,
}