using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InteractiveToolsFramework;

[UEnum]
public enum EToolShutdownType : byte
{
    Completed=0,
    Accept=1,
    Cancel=2,
}