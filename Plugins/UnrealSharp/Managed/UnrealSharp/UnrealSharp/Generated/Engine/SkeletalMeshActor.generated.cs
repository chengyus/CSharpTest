// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SkeletalMeshActor : UnrealSharp.Engine.Actor
{
    
    static SkeletalMeshActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SkeletalMeshActor");
        
        bShouldDoAnimNotifies_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShouldDoAnimNotifies");
        bShouldDoAnimNotifies_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShouldDoAnimNotifies");
        SkeletalMeshComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SkeletalMeshComponent");
        
        
        
    }
    
    protected SkeletalMeshActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/Engine.SkeletalMeshActor:bShouldDoAnimNotifies
    static readonly int bShouldDoAnimNotifies_Offset;
    static readonly IntPtr bShouldDoAnimNotifies_NativeProperty;
    
    public bool bShouldDoAnimNotifies
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bShouldDoAnimNotifies_NativeProperty, bShouldDoAnimNotifies_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bShouldDoAnimNotifies_NativeProperty, bShouldDoAnimNotifies_Offset, value);
        }
    }
    
    // ObjectProperty /Script/Engine.SkeletalMeshActor:SkeletalMeshComponent
    static readonly int SkeletalMeshComponent_Offset;
    
    public UnrealSharp.Engine.SkeletalMeshComponent SkeletalMeshComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SkeletalMeshComponent>.FromNative(IntPtr.Add(NativeObject, SkeletalMeshComponent_Offset), 0, this);
        }
    }
    
    
}