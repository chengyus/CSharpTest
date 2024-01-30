using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioExtensions;

[UEnum]
public enum EAudioParameterType : byte
{
    None=0,
    Boolean=1,
    Integer=2,
    Float=3,
    String=4,
    Object=5,
    BooleanArray=7,
    IntegerArray=8,
    FloatArray=9,
    StringArray=10,
    ObjectArray=11,
    Trigger=12,
}