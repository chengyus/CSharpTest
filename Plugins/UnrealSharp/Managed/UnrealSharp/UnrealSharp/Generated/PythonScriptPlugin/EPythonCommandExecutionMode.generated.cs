using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UEnum]
public enum EPythonCommandExecutionMode : byte
{
    ExecuteFile=0,
    ExecuteStatement=1,
    EvaluateStatement=2,
}