// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SplineMeshActor : UnrealSharp.Engine.Actor
{
    
    static SplineMeshActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SplineMeshActor");
        
        SplineMeshComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SplineMeshComponent");
        
        
        
    }
    
    protected SplineMeshActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.SplineMeshActor:SplineMeshComponent
    static readonly int SplineMeshComponent_Offset;
    
    public UnrealSharp.Engine.SplineMeshComponent SplineMeshComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SplineMeshComponent>.FromNative(IntPtr.Add(NativeObject, SplineMeshComponent_Offset), 0, this);
        }
    }
    
    
}