using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

public partial interface IActorSoundParameterInterface
{
    public void GetActorSoundParams(out System.Collections.Generic.IList<UnrealSharp.AudioExtensions.AudioParameter> @params);
}