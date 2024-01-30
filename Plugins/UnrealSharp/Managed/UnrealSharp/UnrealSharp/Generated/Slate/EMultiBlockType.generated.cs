using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EMultiBlockType : byte
{
    None=0,
    ButtonRow=1,
    EditableText=2,
    Heading=3,
    MenuEntry=4,
    Separator=5,
    ToolBarButton=6,
    ToolBarComboButton=7,
    Widget=8,
}