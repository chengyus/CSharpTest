using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct AssetCompileData
{
    // WeakObjectProperty /Script/Engine.AssetCompileData:Asset
    public WeakObject<UnrealSharp.CoreUObject.Object> Asset;
    
}