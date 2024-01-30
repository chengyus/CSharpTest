using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EVirtualKeyboardDismissAction : byte
{
    TextChangeOnDismiss=0,
    TextCommitOnAccept=1,
    TextCommitOnDismiss=2,
}