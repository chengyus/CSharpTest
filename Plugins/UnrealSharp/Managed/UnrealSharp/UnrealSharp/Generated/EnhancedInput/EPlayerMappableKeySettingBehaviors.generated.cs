using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EPlayerMappableKeySettingBehaviors : byte
{
    InheritSettingsFromAction=0,
    OverrideSettings=1,
    IgnoreSettings=2,
}