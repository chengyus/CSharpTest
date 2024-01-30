using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UEnum]
public enum EGLTFMaterialBakeSizePOT : byte
{
    POT_1=0,
    POT_2=1,
    POT_4=2,
    POT_8=3,
    POT_16=4,
    POT_32=5,
    POT_64=6,
    POT_128=7,
    POT_256=8,
    POT_512=9,
    POT_1024=10,
    POT_2048=11,
    POT_4096=12,
    POT_8192=13,
}