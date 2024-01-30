using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESourceEffectDynamicsProcessorType : byte
{
    Compressor=0,
    Limiter=1,
    Expander=2,
    Gate=3,
    UpwardsCompressor=4,
}