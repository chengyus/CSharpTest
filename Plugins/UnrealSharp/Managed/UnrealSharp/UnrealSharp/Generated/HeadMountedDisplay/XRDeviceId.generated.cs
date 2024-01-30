using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UStruct(IsBlittable = true)]
public partial struct XRDeviceId
{
    // NameProperty /Script/HeadMountedDisplay.XRDeviceId:SystemName
    public Name SystemName;
    
    // IntProperty /Script/HeadMountedDisplay.XRDeviceId:DeviceId
    public int DeviceId;
    
}