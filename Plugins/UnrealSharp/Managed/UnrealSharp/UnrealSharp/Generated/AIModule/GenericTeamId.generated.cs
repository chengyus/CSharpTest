using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct(IsBlittable = true)]
public partial struct GenericTeamId
{
    // ByteProperty /Script/AIModule.GenericTeamId:TeamID
    public byte TeamID;
    
}