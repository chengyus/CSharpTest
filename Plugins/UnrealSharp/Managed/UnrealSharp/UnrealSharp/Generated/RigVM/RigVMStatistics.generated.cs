using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct RigVMStatistics
{
    // IntProperty /Script/RigVM.RigVMStatistics:BytesForCDO
    public int BytesForCDO;
    
    // IntProperty /Script/RigVM.RigVMStatistics:BytesPerInstance
    public int BytesPerInstance;
    
    // StructProperty /Script/RigVM.RigVMStatistics:LiteralMemory
    public UnrealSharp.RigVM.RigVMMemoryStatistics LiteralMemory;
    
    // StructProperty /Script/RigVM.RigVMStatistics:WorkMemory
    public UnrealSharp.RigVM.RigVMMemoryStatistics WorkMemory;
    
    // StructProperty /Script/RigVM.RigVMStatistics:DebugMemory
    public UnrealSharp.RigVM.RigVMMemoryStatistics DebugMemory;
    
    // IntProperty /Script/RigVM.RigVMStatistics:BytesForCaching
    public int BytesForCaching;
    
    // StructProperty /Script/RigVM.RigVMStatistics:ByteCode
    public UnrealSharp.RigVM.RigVMByteCodeStatistics ByteCode;
    
}