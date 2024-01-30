using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UEnum]
public enum EAbcGeometryCacheMotionVectorsImport : byte
{
    NoMotionVectors=0,
    ImportAbcVelocitiesAsMotionVectors=1,
    CalculateMotionVectorsDuringImport=2,
}