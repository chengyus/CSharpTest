using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct SolverIterations
{
    // IntProperty /Script/Engine.SolverIterations:SolverIterations
    public int K2_SolverIterations;
    
    // IntProperty /Script/Engine.SolverIterations:JointIterations
    public int JointIterations;
    
    // IntProperty /Script/Engine.SolverIterations:CollisionIterations
    public int CollisionIterations;
    
    // IntProperty /Script/Engine.SolverIterations:SolverPushOutIterations
    public int SolverPushOutIterations;
    
    // IntProperty /Script/Engine.SolverIterations:JointPushOutIterations
    public int JointPushOutIterations;
    
    // IntProperty /Script/Engine.SolverIterations:CollisionPushOutIterations
    public int CollisionPushOutIterations;
    
}