using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESoundAssetCompressionType : byte
{
    BinkAudio=0,
    ADPCM=1,
    PCM=2,
    PlatformSpecific=3,
    ProjectDefined=4,
}