using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum MediaTextureOutputFormat : byte
{
    MTOF_Default=0,
    MTOF_SRGB_LINOUT=1,
}