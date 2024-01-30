// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialInstanceActor : UnrealSharp.Engine.Actor
{
    
    static MaterialInstanceActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialInstanceActor");
        
        TargetActors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetActors");
        TargetActors_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TargetActors");
        
        
        
    }
    
    protected MaterialInstanceActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ArrayProperty /Script/Engine.MaterialInstanceActor:TargetActors
    static readonly int TargetActors_Offset;
    static readonly IntPtr TargetActors_NativeProperty;
    UnrealArrayReadWriteMarshaler<UnrealSharp.Engine.Actor> TargetActors_Wrapper = null;
    
    public System.Collections.Generic.IList<UnrealSharp.Engine.Actor> TargetActors
    {
        get
        {
            if(TargetActors_Wrapper == null)
            {
                TargetActors_Wrapper = new UnrealArrayReadWriteMarshaler<UnrealSharp.Engine.Actor>(1, TargetActors_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative);
            }
            
            return TargetActors_Wrapper.FromNative(IntPtr.Add(NativeObject,TargetActors_Offset),0,this);
        }
    }
    
    
}