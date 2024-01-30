using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERigVMParameterType : byte
{
    Input=0,
    Output=1,
    Invalid=2,
}