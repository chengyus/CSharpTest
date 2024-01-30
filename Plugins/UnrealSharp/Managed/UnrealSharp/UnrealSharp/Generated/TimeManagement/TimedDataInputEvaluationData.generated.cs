using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TimeManagement;

[UStruct(IsBlittable = true)]
public partial struct TimedDataInputEvaluationData
{
    // FloatProperty /Script/TimeManagement.TimedDataInputEvaluationData:DistanceToNewestSampleSeconds
    public float DistanceToNewestSampleSeconds;
    
    // FloatProperty /Script/TimeManagement.TimedDataInputEvaluationData:DistanceToOldestSampleSeconds
    public float DistanceToOldestSampleSeconds;
    
}