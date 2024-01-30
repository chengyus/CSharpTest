using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct RigVMMemoryStatistics
{
    // IntProperty /Script/RigVM.RigVMMemoryStatistics:RegisterCount
    public int RegisterCount;
    
    // IntProperty /Script/RigVM.RigVMMemoryStatistics:DataBytes
    public int DataBytes;
    
    // IntProperty /Script/RigVM.RigVMMemoryStatistics:TotalBytes
    public int TotalBytes;
    
}