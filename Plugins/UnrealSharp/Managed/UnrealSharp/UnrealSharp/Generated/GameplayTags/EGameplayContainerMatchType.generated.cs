using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayTags;

[UEnum]
public enum EGameplayContainerMatchType : byte
{
    Any=0,
    All=1,
}