using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct ControlRigComponentMappedBone
{
    // NameProperty /Script/ControlRig.ControlRigComponentMappedBone:Source
    public Name Source;
    
    // NameProperty /Script/ControlRig.ControlRigComponentMappedBone:Target
    public Name Target;
    
}