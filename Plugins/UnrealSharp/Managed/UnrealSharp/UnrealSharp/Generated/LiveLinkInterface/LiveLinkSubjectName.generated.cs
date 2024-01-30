using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct(IsBlittable = true)]
public partial struct LiveLinkSubjectName
{
    // NameProperty /Script/LiveLinkInterface.LiveLinkSubjectName:Name
    public Name Name;
    
}