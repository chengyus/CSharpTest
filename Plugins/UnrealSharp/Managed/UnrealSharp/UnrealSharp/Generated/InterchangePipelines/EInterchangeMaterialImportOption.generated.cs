using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UEnum]
public enum EInterchangeMaterialImportOption : byte
{
    ImportAsMaterials=0,
    ImportAsMaterialInstances=1,
}