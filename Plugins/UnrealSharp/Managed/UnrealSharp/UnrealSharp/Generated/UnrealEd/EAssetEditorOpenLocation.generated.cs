using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EAssetEditorOpenLocation : byte
{
    Default=0,
    NewWindow=1,
    MainWindow=2,
    ContentBrowser=3,
    LastDockedWindowOrNewWindow=4,
    LastDockedWindowOrMainWindow=5,
    LastDockedWindowOrContentBrowser=6,
}