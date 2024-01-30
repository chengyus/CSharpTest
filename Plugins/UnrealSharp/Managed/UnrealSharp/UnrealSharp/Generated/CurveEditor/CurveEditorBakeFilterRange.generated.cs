using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CurveEditor;

[UStruct(IsBlittable = true)]
public partial struct CurveEditorBakeFilterRange
{
    // StructProperty /Script/CurveEditor.CurveEditorBakeFilterRange:Min
    public UnrealSharp.CoreUObject.FrameNumber Min;
    
    // StructProperty /Script/CurveEditor.CurveEditorBakeFilterRange:Max
    public UnrealSharp.CoreUObject.FrameNumber Max;
    
}