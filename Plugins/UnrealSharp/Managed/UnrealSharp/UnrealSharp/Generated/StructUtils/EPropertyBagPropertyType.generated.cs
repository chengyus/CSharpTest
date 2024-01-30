using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StructUtils;

[UEnum]
public enum EPropertyBagPropertyType : byte
{
    Bool=1,
    Byte=2,
    Int32=3,
    Int64=4,
    Float=5,
    Double=6,
    Name=7,
    String=8,
    Text=9,
}