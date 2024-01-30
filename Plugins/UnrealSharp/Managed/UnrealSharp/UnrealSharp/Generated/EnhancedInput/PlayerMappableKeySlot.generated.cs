using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct(IsBlittable = true)]
public partial struct PlayerMappableKeySlotData
{
    // IntProperty /Script/EnhancedInput.PlayerMappableKeySlot:SlotNumber
    public int SlotNumber;
    
}