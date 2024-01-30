using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundFrontend;

[UStruct(IsBlittable = true)]
public partial struct MetasoundFrontendVersionNumber
{
    // IntProperty /Script/MetasoundFrontend.MetasoundFrontendVersionNumber:Major
    public int Major;
    
    // IntProperty /Script/MetasoundFrontend.MetasoundFrontendVersionNumber:Minor
    public int Minor;
    
}