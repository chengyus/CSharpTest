using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UEnum]
public enum EPythonLogOutputType : byte
{
    Info=0,
    Warning=1,
    Error=2,
}