using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigUnit_SetMultiControlInteger_Entry
{
    // NameProperty /Script/ControlRig.RigUnit_SetMultiControlInteger_Entry:Control
    public Name Control;
    
    // IntProperty /Script/ControlRig.RigUnit_SetMultiControlInteger_Entry:IntegerValue
    public int IntegerValue;
    
}