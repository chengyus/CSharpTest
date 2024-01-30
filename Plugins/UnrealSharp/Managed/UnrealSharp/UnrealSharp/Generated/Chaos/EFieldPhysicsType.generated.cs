using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldPhysicsType : byte
{
    Field_DynamicState=1,
    Field_LinearForce=2,
    Field_ExternalClusterStrain=3,
    Field_Kill=4,
    Field_LinearVelocity=5,
    Field_AngularVelociy=6,
    Field_AngularTorque=7,
    Field_InternalClusterStrain=8,
    Field_DisableThreshold=9,
    Field_SleepingThreshold=10,
    Field_CollisionGroup=15,
    Field_ActivateDisabled=16,
}