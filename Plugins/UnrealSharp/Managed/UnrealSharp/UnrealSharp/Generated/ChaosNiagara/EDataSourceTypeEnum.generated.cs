using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum EDataSourceTypeEnum : byte
{
    ChaosNiagara_DataSourceType_Collision=0,
    ChaosNiagara_DataSourceType_Breaking=1,
    ChaosNiagara_DataSourceType_Trailing=2,
}