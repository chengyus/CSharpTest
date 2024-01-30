using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct SoftWorldReference
{
    // SoftObjectProperty /Script/Engine.SoftWorldReference:WorldAsset
    public SoftObject<UnrealSharp.Engine.World> WorldAsset;
    
}