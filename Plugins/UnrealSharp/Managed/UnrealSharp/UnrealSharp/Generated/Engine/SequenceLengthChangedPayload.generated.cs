using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct SequenceLengthChangedPayload
{
    // FloatProperty /Script/Engine.SequenceLengthChangedPayload:PreviousLength
    public float PreviousLength;
    
    // FloatProperty /Script/Engine.SequenceLengthChangedPayload:T0
    public float T0;
    
    // FloatProperty /Script/Engine.SequenceLengthChangedPayload:T1
    public float T1;
    
    // StructProperty /Script/Engine.SequenceLengthChangedPayload:PreviousNumberOfFrames
    public UnrealSharp.CoreUObject.FrameNumber PreviousNumberOfFrames;
    
    // StructProperty /Script/Engine.SequenceLengthChangedPayload:Frame0
    public UnrealSharp.CoreUObject.FrameNumber Frame0;
    
    // StructProperty /Script/Engine.SequenceLengthChangedPayload:Frame1
    public UnrealSharp.CoreUObject.FrameNumber Frame1;
    
}