using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ImageWriteQueue;

[UEnum]
public enum EDesiredImageFormat : byte
{
    PNG=0,
    JPG=1,
    BMP=2,
    EXR=3,
}