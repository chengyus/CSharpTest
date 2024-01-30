using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigUnit_SetMultiControlFloat_Entry
{
    // NameProperty /Script/ControlRig.RigUnit_SetMultiControlFloat_Entry:Control
    public Name Control;
    
    // FloatProperty /Script/ControlRig.RigUnit_SetMultiControlFloat_Entry:FloatValue
    public float FloatValue;
    
}