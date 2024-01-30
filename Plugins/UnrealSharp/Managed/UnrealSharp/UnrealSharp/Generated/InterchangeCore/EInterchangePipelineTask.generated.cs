using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeCore;

[UEnum]
public enum EInterchangePipelineTask : byte
{
    PostTranslator=0,
    PostFactory=1,
    PostImport=2,
    Export=3,
}