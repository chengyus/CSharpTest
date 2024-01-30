using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct MarkerSyncAnimPosition
{
    // NameProperty /Script/Engine.MarkerSyncAnimPosition:PreviousMarkerName
    public Name PreviousMarkerName;
    
    // NameProperty /Script/Engine.MarkerSyncAnimPosition:NextMarkerName
    public Name NextMarkerName;
    
    // FloatProperty /Script/Engine.MarkerSyncAnimPosition:PositionBetweenMarkers
    public float PositionBetweenMarkers;
    
}