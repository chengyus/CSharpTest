using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeCore;

[UEnum]
public enum EInterchangeNodeContainerType : byte
{
    None=0,
    TranslatedScene=1,
    TranslatedAsset=2,
    FactoryData=3,
}