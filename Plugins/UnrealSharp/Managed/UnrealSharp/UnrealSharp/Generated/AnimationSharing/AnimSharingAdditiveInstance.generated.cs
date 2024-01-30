// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationSharing;

[UClass]
public partial class AnimSharingAdditiveInstance : UnrealSharp.Engine.AnimInstance
{
    
    static AnimSharingAdditiveInstance()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimSharingAdditiveInstance");
        
        BaseComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseComponent");
        AdditiveAnimation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AdditiveAnimation");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        bStateBool_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStateBool");
        
        
        
    }
    
    protected AnimSharingAdditiveInstance(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // WeakObjectProperty /Script/AnimationSharing.AnimSharingAdditiveInstance:BaseComponent
    static readonly int BaseComponent_Offset;
    
    public WeakObject<UnrealSharp.Engine.SkeletalMeshComponent> BaseComponent
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<WeakObject<UnrealSharp.Engine.SkeletalMeshComponent>>.FromNative(IntPtr.Add(NativeObject, BaseComponent_Offset), 0, this);
        }
    }
    
    // WeakObjectProperty /Script/AnimationSharing.AnimSharingAdditiveInstance:AdditiveAnimation
    static readonly int AdditiveAnimation_Offset;
    
    public WeakObject<UnrealSharp.Engine.AnimSequence> AdditiveAnimation
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<WeakObject<UnrealSharp.Engine.AnimSequence>>.FromNative(IntPtr.Add(NativeObject, AdditiveAnimation_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/AnimationSharing.AnimSharingAdditiveInstance:Alpha
    static readonly int Alpha_Offset;
    
    public float Alpha
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Alpha_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/AnimationSharing.AnimSharingAdditiveInstance:bStateBool
    static readonly int bStateBool_Offset;
    
    public bool bStateBool
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bStateBool_Offset), 0, this);
        }
    }
    
    
}