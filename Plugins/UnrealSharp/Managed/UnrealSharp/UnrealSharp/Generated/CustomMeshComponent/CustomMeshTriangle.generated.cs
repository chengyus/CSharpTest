using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CustomMeshComponent;

[UStruct(IsBlittable = true)]
public partial struct CustomMeshTriangle
{
    // StructProperty /Script/CustomMeshComponent.CustomMeshTriangle:Vertex0
    public System.DoubleNumerics.Vector3 Vertex0;
    
    // StructProperty /Script/CustomMeshComponent.CustomMeshTriangle:Vertex1
    public System.DoubleNumerics.Vector3 Vertex1;
    
    // StructProperty /Script/CustomMeshComponent.CustomMeshTriangle:Vertex2
    public System.DoubleNumerics.Vector3 Vertex2;
    
}