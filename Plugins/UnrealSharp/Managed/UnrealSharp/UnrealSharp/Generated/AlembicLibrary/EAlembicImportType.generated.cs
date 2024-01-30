using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UEnum]
public enum EAlembicImportType : byte
{
    StaticMesh=0,
    GeometryCache=1,
    Skeletal=2,
}