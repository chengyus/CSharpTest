using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UEnum]
public enum EAbcConversionPreset : byte
{
    Maya=0,
    Max=1,
    Custom=2,
}