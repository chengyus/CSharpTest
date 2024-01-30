using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

public partial interface ISoundEffectPresetWidgetInterface
{
    public void OnPropertyChanged(UnrealSharp.Engine.SoundEffectPreset preset, Name propertyName);
    public void OnConstructed(UnrealSharp.Engine.SoundEffectPreset preset);
    public SubclassOf<UnrealSharp.Engine.SoundEffectPreset> GetClass();
}