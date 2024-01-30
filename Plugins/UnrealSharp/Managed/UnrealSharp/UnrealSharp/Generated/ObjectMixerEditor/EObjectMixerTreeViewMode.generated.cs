using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ObjectMixerEditor;

[UEnum]
public enum EObjectMixerTreeViewMode : byte
{
    NoFolders=0,
    Folders=1,
}