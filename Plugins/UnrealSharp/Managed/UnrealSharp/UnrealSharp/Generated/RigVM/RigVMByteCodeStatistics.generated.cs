using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct RigVMByteCodeStatistics
{
    // IntProperty /Script/RigVM.RigVMByteCodeStatistics:InstructionCount
    public int InstructionCount;
    
    // IntProperty /Script/RigVM.RigVMByteCodeStatistics:DataBytes
    public int DataBytes;
    
}