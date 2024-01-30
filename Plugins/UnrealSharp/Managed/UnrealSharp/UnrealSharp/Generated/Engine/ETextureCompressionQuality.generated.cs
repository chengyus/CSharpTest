using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETextureCompressionQuality : byte
{
    TCQ_Default=0,
    TCQ_Lowest=1,
    TCQ_Low=2,
    TCQ_Medium=3,
    TCQ_High=4,
    TCQ_Highest=5,
}