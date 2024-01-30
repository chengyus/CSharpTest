using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AssetTools;

[UEnum]
public enum EAssetMigrationConflict : byte
{
    Skip=0,
    Overwrite=1,
    Cancel=2,
}