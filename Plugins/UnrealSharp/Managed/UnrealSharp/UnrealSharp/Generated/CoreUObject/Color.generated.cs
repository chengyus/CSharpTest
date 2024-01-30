using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Color
{
    // ByteProperty /Script/CoreUObject.Color:B
    public byte B;
    
    // ByteProperty /Script/CoreUObject.Color:G
    public byte G;
    
    // ByteProperty /Script/CoreUObject.Color:R
    public byte R;
    
    // ByteProperty /Script/CoreUObject.Color:A
    public byte A;
    
}