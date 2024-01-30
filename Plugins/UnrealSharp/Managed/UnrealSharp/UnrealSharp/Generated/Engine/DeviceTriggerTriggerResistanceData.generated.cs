using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct DeviceTriggerTriggerResistanceData
{
    // IntProperty /Script/Engine.DeviceTriggerTriggerResistanceData:StartPosition
    public int StartPosition;
    
    // IntProperty /Script/Engine.DeviceTriggerTriggerResistanceData:StartStrengh
    public int StartStrengh;
    
    // IntProperty /Script/Engine.DeviceTriggerTriggerResistanceData:EndPosition
    public int EndPosition;
    
    // IntProperty /Script/Engine.DeviceTriggerTriggerResistanceData:EndStrengh
    public int EndStrengh;
    
}