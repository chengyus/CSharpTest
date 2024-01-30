using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFbxExportCompatibility : byte
{
    FBX_2011=0,
    FBX_2012=1,
    FBX_2013=2,
    FBX_2014=3,
    FBX_2016=4,
    FBX_2018=5,
    FBX_2019=6,
    FBX_2020=7,
}