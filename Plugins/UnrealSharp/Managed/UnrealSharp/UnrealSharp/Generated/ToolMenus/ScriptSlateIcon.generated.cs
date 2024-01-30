using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct(IsBlittable = true)]
public partial struct ScriptSlateIcon
{
    // NameProperty /Script/ToolMenus.ScriptSlateIcon:StyleSetName
    public Name StyleSetName;
    
    // NameProperty /Script/ToolMenus.ScriptSlateIcon:StyleName
    public Name StyleName;
    
    // NameProperty /Script/ToolMenus.ScriptSlateIcon:SmallStyleName
    public Name SmallStyleName;
    
}