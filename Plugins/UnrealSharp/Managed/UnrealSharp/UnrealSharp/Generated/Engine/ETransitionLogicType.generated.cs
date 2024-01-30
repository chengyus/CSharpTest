using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETransitionLogicType : byte
{
    TLT_StandardBlend=0,
    TLT_Inertialization=1,
    TLT_Custom=2,
}