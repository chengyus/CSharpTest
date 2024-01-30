using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UEnum]
public enum ESequenceTimeUnit : byte
{
    DisplayRate=0,
    TickResolution=1,
}