using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Renderer;

[UEnum]
public enum ESparseVolumeTexturePreviewAttribute : byte
{
    ESVTPA_AttributesA_R=0,
    ESVTPA_AttributesA_G=1,
    ESVTPA_AttributesA_B=2,
    ESVTPA_AttributesA_A=3,
    ESVTPA_AttributesB_R=4,
    ESVTPA_AttributesB_G=5,
    ESVTPA_AttributesB_B=6,
    ESVTPA_AttributesB_A=7,
}