using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UEnum]
public enum EAlembicSamplingType : byte
{
    PerFrame=0,
    PerXFrames=1,
    PerTimeStep=2,
}