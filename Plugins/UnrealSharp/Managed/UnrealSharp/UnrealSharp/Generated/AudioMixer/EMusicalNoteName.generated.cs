using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum EMusicalNoteName : byte
{
    C=0,
    Db=1,
    D=2,
    Eb=3,
    E=4,
    F=5,
    Gb=6,
    G=7,
    Ab=8,
    A=9,
    Bb=10,
    B=11,
}