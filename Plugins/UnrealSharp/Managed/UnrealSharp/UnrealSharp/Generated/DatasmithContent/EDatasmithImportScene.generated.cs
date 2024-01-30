using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UEnum]
public enum EDatasmithImportScene : byte
{
    NewLevel=0,
    CurrentLevel=1,
    AssetsOnly=2,
}