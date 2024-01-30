using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESubmixEffectConvolutionReverbBlockSize : byte
{
    BlockSize256=0,
    BlockSize512=1,
    BlockSize1024=2,
}