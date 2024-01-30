using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct AnimationTrackAddedPayload
{
    // IntProperty /Script/Engine.AnimationTrackAddedPayload:TrackIndex
    public int TrackIndex;
    
}