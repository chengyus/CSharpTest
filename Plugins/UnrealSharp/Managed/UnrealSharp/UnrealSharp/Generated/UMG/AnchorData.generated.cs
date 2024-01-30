using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UStruct(IsBlittable = true)]
public partial struct AnchorData
{
    // StructProperty /Script/UMG.AnchorData:Offsets
    public UnrealSharp.SlateCore.Margin Offsets;
    
    // StructProperty /Script/UMG.AnchorData:Anchors
    public UnrealSharp.Slate.Anchors Anchors;
    
    // StructProperty /Script/UMG.AnchorData:Alignment
    public System.DoubleNumerics.Vector2 Alignment;
    
}