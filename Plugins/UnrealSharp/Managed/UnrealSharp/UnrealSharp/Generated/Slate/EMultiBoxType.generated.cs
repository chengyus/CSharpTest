using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EMultiBoxType : byte
{
    MenuBar=0,
    ToolBar=1,
    VerticalToolBar=2,
    SlimHorizontalToolBar=3,
    UniformToolBar=4,
    Menu=5,
    ButtonRow=6,
    SlimHorizontalUniformToolBar=7,
}