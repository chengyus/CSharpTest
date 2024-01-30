using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECollisionResponse : byte
{
    ECR_Ignore=0,
    ECR_Overlap=1,
    ECR_Block=2,
}