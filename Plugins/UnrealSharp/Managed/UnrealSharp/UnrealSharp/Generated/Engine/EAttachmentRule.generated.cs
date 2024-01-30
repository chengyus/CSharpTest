using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAttachmentRule : byte
{
    KeepRelative=0,
    KeepWorld=1,
    SnapToTarget=2,
}