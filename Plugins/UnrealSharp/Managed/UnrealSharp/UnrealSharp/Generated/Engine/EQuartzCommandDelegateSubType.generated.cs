using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EQuartzCommandDelegateSubType : byte
{
    CommandOnFailedToQueue=0,
    CommandOnQueued=1,
    CommandOnCanceled=2,
    CommandOnAboutToStart=3,
    CommandOnStarted=4,
}