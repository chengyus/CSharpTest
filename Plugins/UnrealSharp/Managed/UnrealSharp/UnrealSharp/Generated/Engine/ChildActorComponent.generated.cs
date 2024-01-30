// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class ChildActorComponent : UnrealSharp.Engine.SceneComponent
{
    
    static ChildActorComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ChildActorComponent");
        
        ChildActorClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChildActorClass");
        ChildActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChildActor");
        
        SetChildActorClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetChildActorClass");
        SetChildActorClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetChildActorClass_NativeFunction);
        SetChildActorClass_InClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetChildActorClass_NativeFunction, "InClass");
        
        
    }
    
    protected ChildActorComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ClassProperty /Script/Engine.ChildActorComponent:ChildActorClass
    static readonly int ChildActorClass_Offset;
    
    public SubclassOf<UnrealSharp.Engine.Actor> ChildActorClass
    {
        get
        {
            CheckObjectForValidity();
            return SubclassOfMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(NativeObject, ChildActorClass_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Engine.ChildActorComponent:ChildActor
    static readonly int ChildActor_Offset;
    
    public UnrealSharp.Engine.Actor ChildActor
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(NativeObject, ChildActor_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.ChildActorComponent:SetChildActorClass
    static readonly IntPtr SetChildActorClass_NativeFunction;
    static readonly int SetChildActorClass_ParamsSize;
    static readonly int SetChildActorClass_InClass_Offset;
    
    public void SetChildActorClass(SubclassOf<UnrealSharp.Engine.Actor> inClass)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetChildActorClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            SubclassOfMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, SetChildActorClass_InClass_Offset), 0, null, inClass);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetChildActorClass_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}