using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct QualifiedTime
{
    // StructProperty /Script/CoreUObject.QualifiedFrameTime:Time
    public UnrealSharp.CoreUObject.FrameTime Time;
    
    // StructProperty /Script/CoreUObject.QualifiedFrameTime:Rate
    public UnrealSharp.CoreUObject.FrameRate Rate;
    
}