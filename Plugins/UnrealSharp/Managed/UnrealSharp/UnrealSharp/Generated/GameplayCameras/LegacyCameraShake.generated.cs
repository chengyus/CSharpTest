// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UClass]
public partial class LegacyCameraShake : UnrealSharp.Engine.CameraShakeBase
{
    
    static readonly IntPtr NativeClassPtr;
    static LegacyCameraShake()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("LegacyCameraShake");
        
        RotOscillation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotOscillation");
        LocOscillation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocOscillation");
        FOVOscillation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FOVOscillation");
        OscillatorTimeRemaining_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OscillatorTimeRemaining");
        
        StartLegacyCameraShakeFromSource_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartLegacyCameraShakeFromSource");
        StartLegacyCameraShakeFromSource_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StartLegacyCameraShakeFromSource_NativeFunction);
        StartLegacyCameraShakeFromSource_PlayerCameraManager_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "PlayerCameraManager");
        StartLegacyCameraShakeFromSource_ShakeClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "ShakeClass");
        StartLegacyCameraShakeFromSource_SourceComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "SourceComponent");
        StartLegacyCameraShakeFromSource_Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "Scale");
        StartLegacyCameraShakeFromSource_PlaySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "PlaySpace");
        StartLegacyCameraShakeFromSource_UserPlaySpaceRot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "UserPlaySpaceRot");
        StartLegacyCameraShakeFromSource_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShakeFromSource_NativeFunction, "ReturnValue");
        StartLegacyCameraShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartLegacyCameraShake");
        StartLegacyCameraShake_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StartLegacyCameraShake_NativeFunction);
        StartLegacyCameraShake_PlayerCameraManager_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShake_NativeFunction, "PlayerCameraManager");
        StartLegacyCameraShake_ShakeClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShake_NativeFunction, "ShakeClass");
        StartLegacyCameraShake_Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShake_NativeFunction, "Scale");
        StartLegacyCameraShake_PlaySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShake_NativeFunction, "PlaySpace");
        StartLegacyCameraShake_UserPlaySpaceRot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShake_NativeFunction, "UserPlaySpaceRot");
        StartLegacyCameraShake_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartLegacyCameraShake_NativeFunction, "ReturnValue");
        
        IntPtr ReceiveStopShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveStopShake");
        ReceiveStopShake_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveStopShake_NativeFunction);
        ReceiveStopShake_bImmediately_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveStopShake_NativeFunction, "bImmediately");
        
        IntPtr ReceivePlayShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceivePlayShake");
        ReceivePlayShake_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceivePlayShake_NativeFunction);
        ReceivePlayShake_Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceivePlayShake_NativeFunction, "Scale");
        
        IntPtr ReceiveIsFinished_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveIsFinished");
        ReceiveIsFinished_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveIsFinished_NativeFunction);
        ReceiveIsFinished_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveIsFinished_NativeFunction, "ReturnValue");
        
        IntPtr BlueprintUpdateCameraShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "BlueprintUpdateCameraShake");
        BlueprintUpdateCameraShake_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(BlueprintUpdateCameraShake_NativeFunction);
        BlueprintUpdateCameraShake_DeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BlueprintUpdateCameraShake_NativeFunction, "DeltaTime");
        BlueprintUpdateCameraShake_Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BlueprintUpdateCameraShake_NativeFunction, "Alpha");
        BlueprintUpdateCameraShake_POV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BlueprintUpdateCameraShake_NativeFunction, "POV");
        BlueprintUpdateCameraShake_ModifiedPOV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BlueprintUpdateCameraShake_NativeFunction, "ModifiedPOV");
        
        
    }
    
    protected LegacyCameraShake(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/GameplayCameras.LegacyCameraShake:RotOscillation
    static readonly int RotOscillation_Offset;
    
    public UnrealSharp.GameplayCameras.ROscillator RotOscillation
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GameplayCameras.ROscillatorMarshaler.FromNative(IntPtr.Add(NativeObject, RotOscillation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.GameplayCameras.ROscillatorMarshaler.ToNative(IntPtr.Add(NativeObject, RotOscillation_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/GameplayCameras.LegacyCameraShake:LocOscillation
    static readonly int LocOscillation_Offset;
    
    public UnrealSharp.GameplayCameras.VOscillator LocOscillation
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GameplayCameras.VOscillatorMarshaler.FromNative(IntPtr.Add(NativeObject, LocOscillation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.GameplayCameras.VOscillatorMarshaler.ToNative(IntPtr.Add(NativeObject, LocOscillation_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/GameplayCameras.LegacyCameraShake:FOVOscillation
    static readonly int FOVOscillation_Offset;
    
    public UnrealSharp.GameplayCameras.FOscillator FOVOscillation
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GameplayCameras.FOscillatorMarshaler.FromNative(IntPtr.Add(NativeObject, FOVOscillation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.GameplayCameras.FOscillatorMarshaler.ToNative(IntPtr.Add(NativeObject, FOVOscillation_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/GameplayCameras.LegacyCameraShake:OscillatorTimeRemaining
    static readonly int OscillatorTimeRemaining_Offset;
    
    public float OscillatorTimeRemaining
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OscillatorTimeRemaining_Offset), 0, this);
        }
    }
    
    // Function /Script/GameplayCameras.LegacyCameraShake:StartLegacyCameraShakeFromSource
    static readonly IntPtr StartLegacyCameraShakeFromSource_NativeFunction;
    static readonly int StartLegacyCameraShakeFromSource_ParamsSize;
    static readonly int StartLegacyCameraShakeFromSource_PlayerCameraManager_Offset;
    static readonly int StartLegacyCameraShakeFromSource_ShakeClass_Offset;
    static readonly int StartLegacyCameraShakeFromSource_SourceComponent_Offset;
    static readonly int StartLegacyCameraShakeFromSource_Scale_Offset;
    static readonly int StartLegacyCameraShakeFromSource_PlaySpace_Offset;
    static readonly int StartLegacyCameraShakeFromSource_UserPlaySpaceRot_Offset;
    static readonly int StartLegacyCameraShakeFromSource_ReturnValue_Offset;
    
    public static UnrealSharp.GameplayCameras.LegacyCameraShake StartLegacyCameraShakeFromSource(UnrealSharp.Engine.PlayerCameraManager playerCameraManager, SubclassOf<UnrealSharp.GameplayCameras.LegacyCameraShake> shakeClass, UnrealSharp.Engine.CameraShakeSourceComponent sourceComponent, float scale = 1.000000f, UnrealSharp.Engine.ECameraShakePlaySpace playSpace = UnrealSharp.Engine.ECameraShakePlaySpace.CameraLocal, UnrealSharp.Rotator userPlaySpaceRot = default(UnrealSharp.Rotator))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StartLegacyCameraShakeFromSource_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.PlayerCameraManager>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_PlayerCameraManager_Offset), 0, null, playerCameraManager);
            SubclassOfMarshaller<UnrealSharp.GameplayCameras.LegacyCameraShake>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_ShakeClass_Offset), 0, null, shakeClass);
            ObjectMarshaller<UnrealSharp.Engine.CameraShakeSourceComponent>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_SourceComponent_Offset), 0, null, sourceComponent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_Scale_Offset), 0, null, scale);
            BlittableMarshaller<UnrealSharp.Engine.ECameraShakePlaySpace>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_PlaySpace_Offset), 0, null, playSpace);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_UserPlaySpaceRot_Offset), 0, null, userPlaySpaceRot);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, StartLegacyCameraShakeFromSource_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayCameras.LegacyCameraShake returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.GameplayCameras.LegacyCameraShake>.FromNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShakeFromSource_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GameplayCameras.LegacyCameraShake:StartLegacyCameraShake
    static readonly IntPtr StartLegacyCameraShake_NativeFunction;
    static readonly int StartLegacyCameraShake_ParamsSize;
    static readonly int StartLegacyCameraShake_PlayerCameraManager_Offset;
    static readonly int StartLegacyCameraShake_ShakeClass_Offset;
    static readonly int StartLegacyCameraShake_Scale_Offset;
    static readonly int StartLegacyCameraShake_PlaySpace_Offset;
    static readonly int StartLegacyCameraShake_UserPlaySpaceRot_Offset;
    static readonly int StartLegacyCameraShake_ReturnValue_Offset;
    
    public static UnrealSharp.GameplayCameras.LegacyCameraShake StartLegacyCameraShake(UnrealSharp.Engine.PlayerCameraManager playerCameraManager, SubclassOf<UnrealSharp.GameplayCameras.LegacyCameraShake> shakeClass, float scale = 1.000000f, UnrealSharp.Engine.ECameraShakePlaySpace playSpace = UnrealSharp.Engine.ECameraShakePlaySpace.CameraLocal, UnrealSharp.Rotator userPlaySpaceRot = default(UnrealSharp.Rotator))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StartLegacyCameraShake_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.PlayerCameraManager>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShake_PlayerCameraManager_Offset), 0, null, playerCameraManager);
            SubclassOfMarshaller<UnrealSharp.GameplayCameras.LegacyCameraShake>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShake_ShakeClass_Offset), 0, null, shakeClass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShake_Scale_Offset), 0, null, scale);
            BlittableMarshaller<UnrealSharp.Engine.ECameraShakePlaySpace>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShake_PlaySpace_Offset), 0, null, playSpace);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShake_UserPlaySpaceRot_Offset), 0, null, userPlaySpaceRot);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, StartLegacyCameraShake_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayCameras.LegacyCameraShake returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.GameplayCameras.LegacyCameraShake>.FromNative(IntPtr.Add(ParamsBuffer, StartLegacyCameraShake_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GameplayCameras.LegacyCameraShake:ReceiveStopShake
    IntPtr ReceiveStopShake_NativeFunction;
    static readonly int ReceiveStopShake_ParamsSize;
    static readonly int ReceiveStopShake_bImmediately_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void ReceiveStopShake(bool bImmediately)
    {
        unsafe
        {
            if (ReceiveStopShake_NativeFunction == IntPtr.Zero)
            {
                ReceiveStopShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveStopShake");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveStopShake_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, ReceiveStopShake_bImmediately_Offset), 0, null, bImmediately);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveStopShake_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveStopShake_Implementation(bool bImmediately)
    {
    }
    void Invoke_ReceiveStopShake(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool bImmediately = BoolMarshaller.FromNative(IntPtr.Add(buffer, ReceiveStopShake_bImmediately_Offset), 0, null);
            ReceiveStopShake_Implementation(bImmediately);
        }
    }
    
    // Function /Script/GameplayCameras.LegacyCameraShake:ReceivePlayShake
    IntPtr ReceivePlayShake_NativeFunction;
    static readonly int ReceivePlayShake_ParamsSize;
    static readonly int ReceivePlayShake_Scale_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void ReceivePlayShake(float scale)
    {
        unsafe
        {
            if (ReceivePlayShake_NativeFunction == IntPtr.Zero)
            {
                ReceivePlayShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceivePlayShake");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceivePlayShake_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, ReceivePlayShake_Scale_Offset), 0, null, scale);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceivePlayShake_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceivePlayShake_Implementation(float scale)
    {
    }
    void Invoke_ReceivePlayShake(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            float scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, ReceivePlayShake_Scale_Offset), 0, null);
            ReceivePlayShake_Implementation(scale);
        }
    }
    
    // Function /Script/GameplayCameras.LegacyCameraShake:ReceiveIsFinished
    IntPtr ReceiveIsFinished_NativeFunction;
    static readonly int ReceiveIsFinished_ParamsSize;
    static readonly int ReceiveIsFinished_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual bool ReceiveIsFinished()
    {
        unsafe
        {
            if (ReceiveIsFinished_NativeFunction == IntPtr.Zero)
            {
                ReceiveIsFinished_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveIsFinished");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveIsFinished_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveIsFinished_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ReceiveIsFinished_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool ReceiveIsFinished_Implementation()
    {
        return default(bool);
    }
    void Invoke_ReceiveIsFinished(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = ReceiveIsFinished_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    // Function /Script/GameplayCameras.LegacyCameraShake:BlueprintUpdateCameraShake
    IntPtr BlueprintUpdateCameraShake_NativeFunction;
    static readonly int BlueprintUpdateCameraShake_ParamsSize;
    static readonly int BlueprintUpdateCameraShake_DeltaTime_Offset;
    static readonly int BlueprintUpdateCameraShake_Alpha_Offset;
    static readonly int BlueprintUpdateCameraShake_POV_Offset;
    static readonly int BlueprintUpdateCameraShake_ModifiedPOV_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void BlueprintUpdateCameraShake(float deltaTime, float alpha, UnrealSharp.Engine.MinimalViewInfo pOV, out UnrealSharp.Engine.MinimalViewInfo modifiedPOV)
    {
        unsafe
        {
            if (BlueprintUpdateCameraShake_NativeFunction == IntPtr.Zero)
            {
                BlueprintUpdateCameraShake_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "BlueprintUpdateCameraShake");
            }
            byte* ParamsBufferAllocation = stackalloc byte[BlueprintUpdateCameraShake_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, BlueprintUpdateCameraShake_DeltaTime_Offset), 0, null, deltaTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, BlueprintUpdateCameraShake_Alpha_Offset), 0, null, alpha);
            UnrealSharp.Engine.MinimalViewInfoMarshaler.ToNative(IntPtr.Add(ParamsBuffer, BlueprintUpdateCameraShake_POV_Offset), 0, null, pOV);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, BlueprintUpdateCameraShake_NativeFunction, ParamsBuffer);
            
            modifiedPOV = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(ParamsBuffer, BlueprintUpdateCameraShake_ModifiedPOV_Offset), 0, null);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void BlueprintUpdateCameraShake_Implementation(float deltaTime, float alpha, UnrealSharp.Engine.MinimalViewInfo pOV, out UnrealSharp.Engine.MinimalViewInfo modifiedPOV)
    {
        modifiedPOV = default(UnrealSharp.Engine.MinimalViewInfo);
    }
    void Invoke_BlueprintUpdateCameraShake(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            float deltaTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateCameraShake_DeltaTime_Offset), 0, null);
            float alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateCameraShake_Alpha_Offset), 0, null);
            UnrealSharp.Engine.MinimalViewInfo pOV = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(buffer, BlueprintUpdateCameraShake_POV_Offset), 0, null);
            UnrealSharp.Engine.MinimalViewInfo modifiedPOV = default;
            BlueprintUpdateCameraShake_Implementation(deltaTime, alpha, pOV, out modifiedPOV);
            UnrealSharp.Engine.MinimalViewInfoMarshaler.ToNative(IntPtr.Add(buffer, BlueprintUpdateCameraShake_ModifiedPOV_Offset), 0, null, modifiedPOV);
        }
    }
    
    
}