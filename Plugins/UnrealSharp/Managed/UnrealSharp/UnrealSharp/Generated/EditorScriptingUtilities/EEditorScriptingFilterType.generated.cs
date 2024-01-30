using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UEnum]
public enum EEditorScriptingFilterType : byte
{
    Include=0,
    Exclude=1,
}