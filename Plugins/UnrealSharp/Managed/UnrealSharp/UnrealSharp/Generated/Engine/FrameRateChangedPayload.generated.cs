using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct FrameRateChangedPayload
{
    // StructProperty /Script/Engine.FrameRateChangedPayload:PreviousFrameRate
    public UnrealSharp.CoreUObject.FrameRate PreviousFrameRate;
    
}