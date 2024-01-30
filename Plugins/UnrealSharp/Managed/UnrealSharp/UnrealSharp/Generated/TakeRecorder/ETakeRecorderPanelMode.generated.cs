using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorder;

[UEnum]
public enum ETakeRecorderPanelMode : byte
{
    NewRecording=0,
    RecordingInto=1,
    EditingPreset=2,
    ReviewingRecording=3,
}