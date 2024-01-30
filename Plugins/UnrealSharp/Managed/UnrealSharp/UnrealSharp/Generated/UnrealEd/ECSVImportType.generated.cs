using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum ECSVImportType : byte
{
    ECSV_DataTable=0,
    ECSV_CurveTable=1,
    ECSV_CurveFloat=2,
    ECSV_CurveVector=3,
    ECSV_CurveLinearColor=4,
}