using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UEnum]
public enum EPyTestEnum : byte
{
    One=0,
    Two=1,
}