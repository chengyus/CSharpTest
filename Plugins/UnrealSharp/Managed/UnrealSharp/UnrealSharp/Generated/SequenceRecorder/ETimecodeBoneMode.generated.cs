using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequenceRecorder;

[UEnum]
public enum ETimecodeBoneMode : byte
{
    All=0,
    Root=1,
    UserDefined=2,
}