// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Constraints;

[UClass]
abstract public partial class TransformableHandle : UnrealSharp.CoreUObject.Object
{
    
    static TransformableHandle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TransformableHandle");
        
        ConstraintBindingID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConstraintBindingID");
        
        
        
    }
    
    protected TransformableHandle(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Constraints.TransformableHandle:ConstraintBindingID
    static readonly int ConstraintBindingID_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneObjectBindingID ConstraintBindingID
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.FromNative(IntPtr.Add(NativeObject, ConstraintBindingID_Offset), 0, this);
        }
    }
    
    
}