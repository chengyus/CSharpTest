using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioCapture;

[UStruct(IsBlittable = true)]
public partial struct AudioCaptureDeviceInfo
{
    // NameProperty /Script/AudioCapture.AudioCaptureDeviceInfo:DeviceName
    public Name DeviceName;
    
    // IntProperty /Script/AudioCapture.AudioCaptureDeviceInfo:NumInputChannels
    public int NumInputChannels;
    
    // IntProperty /Script/AudioCapture.AudioCaptureDeviceInfo:SampleRate
    public int SampleRate;
    
}