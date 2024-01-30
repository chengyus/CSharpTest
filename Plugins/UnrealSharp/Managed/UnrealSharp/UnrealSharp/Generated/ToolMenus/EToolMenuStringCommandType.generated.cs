using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UEnum]
public enum EToolMenuStringCommandType : byte
{
    Command=0,
    Python=1,
    Custom=2,
}