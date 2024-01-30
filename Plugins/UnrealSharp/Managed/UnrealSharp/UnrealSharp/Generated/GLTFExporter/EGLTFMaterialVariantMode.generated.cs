using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UEnum]
public enum EGLTFMaterialVariantMode : byte
{
    None=0,
    Simple=1,
    UseMeshData=2,
}