using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundFrontend;

[UStruct(IsBlittable = true)]
public partial struct MetasoundFrontendVersion
{
    // NameProperty /Script/MetasoundFrontend.MetasoundFrontendVersion:Name
    public Name Name;
    
    // StructProperty /Script/MetasoundFrontend.MetasoundFrontendVersion:Number
    public UnrealSharp.MetasoundFrontend.MetasoundFrontendVersionNumber Number;
    
}