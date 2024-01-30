using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeCore;

[UEnum]
public enum EInterchangeFactoryAssetType : byte
{
    None=0,
    Textures=1,
    Materials=2,
    Meshes=3,
    Animations=4,
    Physics=5,
}