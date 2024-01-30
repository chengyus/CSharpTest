using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UEnum]
public enum EScriptingCollisionShapeType_Deprecated : byte
{
    Box=0,
    Sphere=1,
    Capsule=2,
    NDOP10_X=3,
    NDOP10_Y=4,
    NDOP10_Z=5,
    NDOP18=6,
    NDOP26=7,
}