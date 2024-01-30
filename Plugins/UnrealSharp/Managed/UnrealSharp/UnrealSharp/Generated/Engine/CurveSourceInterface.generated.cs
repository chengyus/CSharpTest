using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

public partial interface ICurveSourceInterface
{
    public float GetCurveValue(Name curveName);
    public void GetCurves(out System.Collections.Generic.IList<UnrealSharp.Engine.NamedCurveValue> outValues);
    public Name GetBindingName();
}