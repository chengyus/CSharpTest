using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct ControlRigComponentMappedCurve
{
    // NameProperty /Script/ControlRig.ControlRigComponentMappedCurve:Source
    public Name Source;
    
    // NameProperty /Script/ControlRig.ControlRigComponentMappedCurve:Target
    public Name Target;
    
}