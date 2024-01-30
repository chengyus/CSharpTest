using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMGEditor;

[UEnum]
public enum EThumbnailLabelType_BlueprintType : byte
{
    ClassName=0,
    AssetName=1,
    NoLabel=2,
}