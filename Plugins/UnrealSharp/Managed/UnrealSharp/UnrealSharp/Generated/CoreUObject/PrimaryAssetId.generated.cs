using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct PrimaryAssetId
{
    // StructProperty /Script/CoreUObject.PrimaryAssetId:PrimaryAssetType
    public UnrealSharp.CoreUObject.PrimaryAssetType PrimaryAssetType;
    
    // NameProperty /Script/CoreUObject.PrimaryAssetId:PrimaryAssetName
    public Name PrimaryAssetName;
    
}