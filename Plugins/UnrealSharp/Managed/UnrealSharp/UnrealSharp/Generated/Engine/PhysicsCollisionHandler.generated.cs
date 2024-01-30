// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PhysicsCollisionHandler : UnrealSharp.CoreUObject.Object
{
    
    static PhysicsCollisionHandler()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PhysicsCollisionHandler");
        
        ImpactThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImpactThreshold");
        ImpactReFireDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImpactReFireDelay");
        DefaultImpactSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultImpactSound");
        
        
        
    }
    
    protected PhysicsCollisionHandler(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.PhysicsCollisionHandler:ImpactThreshold
    static readonly int ImpactThreshold_Offset;
    
    public float ImpactThreshold
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, ImpactThreshold_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, ImpactThreshold_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.PhysicsCollisionHandler:ImpactReFireDelay
    static readonly int ImpactReFireDelay_Offset;
    
    public float ImpactReFireDelay
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, ImpactReFireDelay_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, ImpactReFireDelay_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/Engine.PhysicsCollisionHandler:DefaultImpactSound
    static readonly int DefaultImpactSound_Offset;
    
    public UnrealSharp.Engine.SoundBase DefaultImpactSound
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SoundBase>.FromNative(IntPtr.Add(NativeObject, DefaultImpactSound_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.SoundBase>.ToNative(IntPtr.Add(NativeObject, DefaultImpactSound_Offset), 0, this, value);
        }
    }
    
    
}