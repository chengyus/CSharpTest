using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EAppMsgType : byte
{
    Ok=0,
    YesNo=1,
    OkCancel=2,
    YesNoCancel=3,
    CancelRetryContinue=4,
    YesNoYesAllNoAll=5,
    YesNoYesAllNoAllCancel=6,
    YesNoYesAll=7,
}