using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeEngine;

[UEnum]
public enum EInterchangePipelineConfigurationDialogResult : byte
{
    Cancel=0,
    Import=1,
    ImportAll=2,
}