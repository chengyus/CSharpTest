using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UEnum]
public enum ENiagaraGpuSyncMode : byte
{
    None=0,
    SyncCpuToGpu=1,
    SyncGpuToCpu=2,
    SyncBoth=3,
}