using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DataValidation;

[UEnum]
public enum EDataValidationUsecase : byte
{
    None=0,
    Manual=1,
    Commandlet=2,
    Save=3,
    PreSubmit=4,
    Script=5,
}