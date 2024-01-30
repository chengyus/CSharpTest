using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioExtensions;

[UStruct(IsBlittable = true)]
public partial struct SoundGeneratorOutput
{
    // NameProperty /Script/AudioExtensions.SoundGeneratorOutput:Name
    public Name Name;
    
}