using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UEnum]
public enum EMeterPeakType : byte
{
    MeanSquared=0,
    RootMeanSquared=1,
    Peak=2,
}