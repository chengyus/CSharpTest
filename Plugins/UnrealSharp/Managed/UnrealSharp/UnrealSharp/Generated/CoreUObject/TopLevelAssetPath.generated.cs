using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct TopLevelAssetPath
{
    // NameProperty /Script/CoreUObject.TopLevelAssetPath:PackageName
    public Name PackageName;
    
    // NameProperty /Script/CoreUObject.TopLevelAssetPath:AssetName
    public Name AssetName;
    
}