using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum EDataSortTypeEnum : byte
{
    ChaosNiagara_DataSortType_NoSorting=0,
    ChaosNiagara_DataSortType_RandomShuffle=1,
    ChaosNiagara_DataSortType_SortByMassMaxToMin=2,
    ChaosNiagara_DataSortType_SortByMassMinToMax=3,
}