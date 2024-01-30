using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldObjectType : byte
{
    Field_Object_Rigid=0,
    Field_Object_Cloth=1,
    Field_Object_Destruction=2,
    Field_Object_Character=3,
    Field_Object_All=4,
}