using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FractureEditor;

[UEnum]
public enum EOutlinerItemNameEnum : byte
{
    BoneName=0,
    BoneIndex=1,
}