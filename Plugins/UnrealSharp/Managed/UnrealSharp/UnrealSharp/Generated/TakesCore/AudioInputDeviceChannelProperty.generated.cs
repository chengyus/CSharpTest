using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakesCore;

[UStruct(IsBlittable = true)]
public partial struct AudioInputDeviceChannelProperty
{
    // IntProperty /Script/TakesCore.AudioInputDeviceChannelProperty:AudioInputDeviceChannel
    public int AudioInputDeviceChannel;
    
}