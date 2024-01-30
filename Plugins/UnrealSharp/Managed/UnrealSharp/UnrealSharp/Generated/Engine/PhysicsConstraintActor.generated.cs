// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PhysicsConstraintActor : UnrealSharp.Engine.RigidBodyBase
{
    
    static PhysicsConstraintActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PhysicsConstraintActor");
        
        ConstraintComp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConstraintComp");
        
        
        
    }
    
    protected PhysicsConstraintActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.PhysicsConstraintActor:ConstraintComp
    static readonly int ConstraintComp_Offset;
    
    public UnrealSharp.Engine.PhysicsConstraintComponent ConstraintComp
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.PhysicsConstraintComponent>.FromNative(IntPtr.Add(NativeObject, ConstraintComp_Offset), 0, this);
        }
    }
    
    
}