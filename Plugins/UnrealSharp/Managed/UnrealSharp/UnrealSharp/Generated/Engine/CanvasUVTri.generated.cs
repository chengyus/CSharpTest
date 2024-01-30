using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct CanvasUVTri
{
    // StructProperty /Script/Engine.CanvasUVTri:V0_Pos
    public System.DoubleNumerics.Vector2 V0_Pos;
    
    // StructProperty /Script/Engine.CanvasUVTri:V0_UV
    public System.DoubleNumerics.Vector2 V0_UV;
    
    // StructProperty /Script/Engine.CanvasUVTri:V0_Color
    public UnrealSharp.CoreUObject.LinearColor V0_Color;
    
    // StructProperty /Script/Engine.CanvasUVTri:V1_Pos
    public System.DoubleNumerics.Vector2 V1_Pos;
    
    // StructProperty /Script/Engine.CanvasUVTri:V1_UV
    public System.DoubleNumerics.Vector2 V1_UV;
    
    // StructProperty /Script/Engine.CanvasUVTri:V1_Color
    public UnrealSharp.CoreUObject.LinearColor V1_Color;
    
    // StructProperty /Script/Engine.CanvasUVTri:V2_Pos
    public System.DoubleNumerics.Vector2 V2_Pos;
    
    // StructProperty /Script/Engine.CanvasUVTri:V2_UV
    public System.DoubleNumerics.Vector2 V2_UV;
    
    // StructProperty /Script/Engine.CanvasUVTri:V2_Color
    public UnrealSharp.CoreUObject.LinearColor V2_Color;
    
}