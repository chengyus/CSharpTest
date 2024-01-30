using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERigVMUserWorkflowType : byte
{
    NodeContext=1,
    PinContext=2,
    OnPinDefaultChanged=3,
    All=4,
}