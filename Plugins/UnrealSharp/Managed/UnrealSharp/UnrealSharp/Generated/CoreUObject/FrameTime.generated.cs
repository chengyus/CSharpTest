using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct FrameTime
{
    // StructProperty /Script/CoreUObject.FrameTime:FrameNumber
    public UnrealSharp.CoreUObject.FrameNumber FrameNumber;
    
    // FloatProperty /Script/CoreUObject.FrameTime:SubFrame
    public float SubFrame;
    
}