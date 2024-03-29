// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Constraints;

[UClass]
public partial class TransformableComponentHandle : UnrealSharp.Constraints.TransformableHandle
{
    
    static TransformableComponentHandle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TransformableComponentHandle");
        
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        SocketName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SocketName");
        
        
        
    }
    
    protected TransformableComponentHandle(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // WeakObjectProperty /Script/Constraints.TransformableComponentHandle:Component
    static readonly int Component_Offset;
    
    public WeakObject<UnrealSharp.Engine.SceneComponent> Component
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<WeakObject<UnrealSharp.Engine.SceneComponent>>.FromNative(IntPtr.Add(NativeObject, Component_Offset), 0, this);
        }
    }
    
    // NameProperty /Script/Constraints.TransformableComponentHandle:SocketName
    static readonly int SocketName_Offset;
    
    public Name SocketName
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<Name>.FromNative(IntPtr.Add(NativeObject, SocketName_Offset), 0, this);
        }
    }
    
    
}