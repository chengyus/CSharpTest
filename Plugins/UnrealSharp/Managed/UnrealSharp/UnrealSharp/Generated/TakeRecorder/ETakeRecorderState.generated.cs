using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorder;

[UEnum]
public enum ETakeRecorderState : byte
{
    CountingDown=0,
    PreRecord=1,
    TickingAfterPre=2,
    Started=3,
    Stopped=4,
    Cancelled=5,
}