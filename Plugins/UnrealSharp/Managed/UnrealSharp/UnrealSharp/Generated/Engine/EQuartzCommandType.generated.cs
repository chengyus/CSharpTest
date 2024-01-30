using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EQuartzCommandType : byte
{
    PlaySound=0,
    QueueSoundToPlay=1,
    RetriggerSound=2,
    TickRateChange=3,
    TransportReset=4,
    StartOtherClock=5,
    Notify=6,
    Custom=7,
}