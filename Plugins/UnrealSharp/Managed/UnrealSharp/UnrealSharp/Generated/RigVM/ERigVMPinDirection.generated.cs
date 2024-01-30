using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERigVMPinDirection : byte
{
    Input=0,
    Output=1,
    IO=2,
    Visible=3,
    Hidden=4,
    Invalid=5,
}