using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorder;

[UEnum]
public enum ETakeRecorderMode : byte
{
    RecordNewSequence=0,
    RecordIntoSequence=1,
}