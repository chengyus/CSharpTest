using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct(IsBlittable = true)]
public partial struct TraceQueryTestNames
{
    // NameProperty /Script/FunctionalTesting.TraceQueryTestNames:ComponentName
    public Name ComponentName;
    
    // NameProperty /Script/FunctionalTesting.TraceQueryTestNames:PhysicalMaterialName
    public Name PhysicalMaterialName;
    
    // NameProperty /Script/FunctionalTesting.TraceQueryTestNames:ActorName
    public Name ActorName;
    
}