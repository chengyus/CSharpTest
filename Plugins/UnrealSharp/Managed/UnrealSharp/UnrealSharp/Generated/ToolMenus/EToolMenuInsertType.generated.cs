using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UEnum]
public enum EToolMenuInsertType : byte
{
    Default=0,
    Before=1,
    After=2,
    First=3,
}