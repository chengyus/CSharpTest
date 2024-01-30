using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundFrontend;

[UStruct(IsBlittable = true)]
public partial struct MetasoundFrontendClassName
{
    // NameProperty /Script/MetasoundFrontend.MetasoundFrontendClassName:Namespace
    public Name Namespace;
    
    // NameProperty /Script/MetasoundFrontend.MetasoundFrontendClassName:Name
    public Name Name;
    
    // NameProperty /Script/MetasoundFrontend.MetasoundFrontendClassName:Variant
    public Name Variant;
    
}