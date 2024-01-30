using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UStruct(IsBlittable = true)]
public partial struct EditorScriptingMeshReductionSettings_Deprecated
{
    // FloatProperty /Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated:PercentTriangles
    public float PercentTriangles;
    
    // FloatProperty /Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated:ScreenSize
    public float ScreenSize;
    
}