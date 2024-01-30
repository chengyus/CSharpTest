using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigElementWeight
{
    // FloatProperty /Script/ControlRig.RigElementWeight:Location
    public float Location;
    
    // FloatProperty /Script/ControlRig.RigElementWeight:Rotation
    public float Rotation;
    
    // FloatProperty /Script/ControlRig.RigElementWeight:Scale
    public float Scale;
    
}