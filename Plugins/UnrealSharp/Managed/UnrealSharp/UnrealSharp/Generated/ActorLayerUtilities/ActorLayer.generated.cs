using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ActorLayerUtilities;

[UStruct(IsBlittable = true)]
public partial struct ActorLayer
{
    // NameProperty /Script/ActorLayerUtilities.ActorLayer:Name
    public Name Name;
    
}