using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshEditor;

[UStruct(IsBlittable = true)]
public partial struct StaticMeshReductionSettings
{
    // FloatProperty /Script/StaticMeshEditor.StaticMeshReductionSettings:PercentTriangles
    public float PercentTriangles;
    
    // FloatProperty /Script/StaticMeshEditor.StaticMeshReductionSettings:ScreenSize
    public float ScreenSize;
    
}