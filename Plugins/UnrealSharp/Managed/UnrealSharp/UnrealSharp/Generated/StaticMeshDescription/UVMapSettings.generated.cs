using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshDescription;

[UStruct(IsBlittable = true)]
public partial struct UVMapSettings
{
    // StructProperty /Script/StaticMeshDescription.UVMapSettings:Size
    public System.DoubleNumerics.Vector3 Size;
    
    // StructProperty /Script/StaticMeshDescription.UVMapSettings:UVTile
    public System.DoubleNumerics.Vector2 UVTile;
    
    // StructProperty /Script/StaticMeshDescription.UVMapSettings:Position
    public System.DoubleNumerics.Vector3 Position;
    
    // StructProperty /Script/StaticMeshDescription.UVMapSettings:Rotation
    public UnrealSharp.Rotator Rotation;
    
    // StructProperty /Script/StaticMeshDescription.UVMapSettings:Scale
    public System.DoubleNumerics.Vector3 Scale;
    
}