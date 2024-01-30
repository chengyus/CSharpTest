using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AndroidFileServer;

[UEnum]
public enum EAFSActiveType : byte
{
    None=0,
    USBOnly=1,
    NetworkOnly=2,
    Combined=3,
}