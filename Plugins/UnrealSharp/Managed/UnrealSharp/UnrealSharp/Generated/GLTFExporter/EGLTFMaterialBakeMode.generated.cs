using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UEnum]
public enum EGLTFMaterialBakeMode : byte
{
    Disabled=0,
    Simple=1,
    UseMeshData=2,
}