using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UEnum]
public enum EEditorScriptingStringMatchType : byte
{
    Contains=0,
    MatchesWildcard=1,
    ExactMatch=2,
}