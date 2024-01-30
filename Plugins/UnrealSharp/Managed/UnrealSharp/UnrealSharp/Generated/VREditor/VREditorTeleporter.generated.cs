// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.VREditor;

[UClass]
public partial class VREditorTeleporter : UnrealSharp.Engine.Actor
{
    
    static VREditorTeleporter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("VREditorTeleporter");
        
        
        StopAiming_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StopAiming");
        StartAiming_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartAiming");
        StartAiming_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StartAiming_NativeFunction);
        StartAiming_Interactor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartAiming_NativeFunction, "Interactor");
        SetVisibility_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVisibility");
        SetVisibility_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVisibility_NativeFunction);
        SetVisibility_bVisible_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVisibility_NativeFunction, "bVisible");
        SetColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetColor");
        SetColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetColor_NativeFunction);
        SetColor_Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetColor_NativeFunction, "Color");
        IsTeleporting_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTeleporting");
        IsTeleporting_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTeleporting_NativeFunction);
        IsTeleporting_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTeleporting_NativeFunction, "ReturnValue");
        IsAiming_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsAiming");
        IsAiming_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsAiming_NativeFunction);
        IsAiming_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsAiming_NativeFunction, "ReturnValue");
        GetVRMode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetVRMode");
        GetVRMode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetVRMode_NativeFunction);
        GetVRMode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVRMode_NativeFunction, "ReturnValue");
        GetInteractorTryingTeleport_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInteractorTryingTeleport");
        GetInteractorTryingTeleport_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInteractorTryingTeleport_NativeFunction);
        GetInteractorTryingTeleport_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInteractorTryingTeleport_NativeFunction, "ReturnValue");
        DoTeleport_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "DoTeleport");
        
        IntPtr Init_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Init");
        Init_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Init_NativeFunction);
        Init_InMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Init_NativeFunction, "InMode");
        
        IntPtr GetSlideDelta_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSlideDelta");
        GetSlideDelta_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSlideDelta_NativeFunction);
        GetSlideDelta_Interactor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSlideDelta_NativeFunction, "Interactor");
        GetSlideDelta_Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSlideDelta_NativeFunction, "Axis");
        GetSlideDelta_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSlideDelta_NativeFunction, "ReturnValue");
        
        
    }
    
    protected VREditorTeleporter(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/VREditor.VREditorTeleporter:StopAiming
    static readonly IntPtr StopAiming_NativeFunction;
    
    public void StopAiming()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StopAiming_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:StartAiming
    static readonly IntPtr StartAiming_NativeFunction;
    static readonly int StartAiming_ParamsSize;
    static readonly int StartAiming_Interactor_Offset;
    
    public void StartAiming(UnrealSharp.ViewportInteraction.ViewportInteractor interactor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StartAiming_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ViewportInteraction.ViewportInteractor>.ToNative(IntPtr.Add(ParamsBuffer, StartAiming_Interactor_Offset), 0, null, interactor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StartAiming_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:SetVisibility
    static readonly IntPtr SetVisibility_NativeFunction;
    static readonly int SetVisibility_ParamsSize;
    static readonly int SetVisibility_bVisible_Offset;
    
    public void SetVisibility(bool bVisible)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetVisibility_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetVisibility_bVisible_Offset), 0, null, bVisible);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetVisibility_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:SetColor
    static readonly IntPtr SetColor_NativeFunction;
    static readonly int SetColor_ParamsSize;
    static readonly int SetColor_Color_Offset;
    
    public void SetColor(UnrealSharp.CoreUObject.LinearColor color)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetColor_Color_Offset), 0, null, color);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetColor_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:IsTeleporting
    static readonly IntPtr IsTeleporting_NativeFunction;
    static readonly int IsTeleporting_ParamsSize;
    static readonly int IsTeleporting_ReturnValue_Offset;
    
    public bool IsTeleporting()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTeleporting_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsTeleporting_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTeleporting_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:IsAiming
    static readonly IntPtr IsAiming_NativeFunction;
    static readonly int IsAiming_ParamsSize;
    static readonly int IsAiming_ReturnValue_Offset;
    
    public bool IsAiming()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsAiming_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsAiming_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsAiming_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:GetVRMode
    static readonly IntPtr GetVRMode_NativeFunction;
    static readonly int GetVRMode_ParamsSize;
    static readonly int GetVRMode_ReturnValue_Offset;
    
    public UnrealSharp.VREditor.VREditorMode GetVRMode()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetVRMode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetVRMode_NativeFunction, ParamsBuffer);
            
            UnrealSharp.VREditor.VREditorMode returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.VREditor.VREditorMode>.FromNative(IntPtr.Add(ParamsBuffer, GetVRMode_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:GetInteractorTryingTeleport
    static readonly IntPtr GetInteractorTryingTeleport_NativeFunction;
    static readonly int GetInteractorTryingTeleport_ParamsSize;
    static readonly int GetInteractorTryingTeleport_ReturnValue_Offset;
    
    public UnrealSharp.ViewportInteraction.ViewportInteractor GetInteractorTryingTeleport()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetInteractorTryingTeleport_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetInteractorTryingTeleport_NativeFunction, ParamsBuffer);
            
            UnrealSharp.ViewportInteraction.ViewportInteractor returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.ViewportInteraction.ViewportInteractor>.FromNative(IntPtr.Add(ParamsBuffer, GetInteractorTryingTeleport_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:DoTeleport
    static readonly IntPtr DoTeleport_NativeFunction;
    
    public void DoTeleport()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, DoTeleport_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:TeleportDone
    IntPtr TeleportDone_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void TeleportDone()
    {
        unsafe
        {
            if (TeleportDone_NativeFunction == IntPtr.Zero)
            {
                TeleportDone_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TeleportDone");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TeleportDone_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void TeleportDone_Implementation()
    {
    }
    void Invoke_TeleportDone(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            TeleportDone_Implementation();
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:StartTeleport
    IntPtr StartTeleport_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void StartTeleport()
    {
        unsafe
        {
            if (StartTeleport_NativeFunction == IntPtr.Zero)
            {
                StartTeleport_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "StartTeleport");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StartTeleport_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void StartTeleport_Implementation()
    {
    }
    void Invoke_StartTeleport(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            StartTeleport_Implementation();
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:Shutdown
    IntPtr Shutdown_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void Shutdown()
    {
        unsafe
        {
            if (Shutdown_NativeFunction == IntPtr.Zero)
            {
                Shutdown_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "Shutdown");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Shutdown_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void Shutdown_Implementation()
    {
    }
    void Invoke_Shutdown(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            Shutdown_Implementation();
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:Init
    IntPtr Init_NativeFunction;
    static readonly int Init_ParamsSize;
    static readonly int Init_InMode_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void Init(UnrealSharp.VREditor.VREditorMode inMode)
    {
        unsafe
        {
            if (Init_NativeFunction == IntPtr.Zero)
            {
                Init_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "Init");
            }
            byte* ParamsBufferAllocation = stackalloc byte[Init_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.VREditor.VREditorMode>.ToNative(IntPtr.Add(ParamsBuffer, Init_InMode_Offset), 0, null, inMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Init_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void Init_Implementation(UnrealSharp.VREditor.VREditorMode inMode)
    {
    }
    void Invoke_Init(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.VREditor.VREditorMode inMode = ObjectMarshaller<UnrealSharp.VREditor.VREditorMode>.FromNative(IntPtr.Add(buffer, Init_InMode_Offset), 0, null);
            Init_Implementation(inMode);
        }
    }
    
    // Function /Script/VREditor.VREditorTeleporter:GetSlideDelta
    IntPtr GetSlideDelta_NativeFunction;
    static readonly int GetSlideDelta_ParamsSize;
    static readonly int GetSlideDelta_Interactor_Offset;
    static readonly int GetSlideDelta_Axis_Offset;
    static readonly int GetSlideDelta_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual float GetSlideDelta(UnrealSharp.VREditor.VREditorInteractor interactor, bool axis)
    {
        unsafe
        {
            if (GetSlideDelta_NativeFunction == IntPtr.Zero)
            {
                GetSlideDelta_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "GetSlideDelta");
            }
            byte* ParamsBufferAllocation = stackalloc byte[GetSlideDelta_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.VREditor.VREditorInteractor>.ToNative(IntPtr.Add(ParamsBuffer, GetSlideDelta_Interactor_Offset), 0, null, interactor);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetSlideDelta_Axis_Offset), 0, null, axis);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSlideDelta_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetSlideDelta_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual float GetSlideDelta_Implementation(UnrealSharp.VREditor.VREditorInteractor interactor, bool axis)
    {
        return default(float);
    }
    void Invoke_GetSlideDelta(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.VREditor.VREditorInteractor interactor = ObjectMarshaller<UnrealSharp.VREditor.VREditorInteractor>.FromNative(IntPtr.Add(buffer, GetSlideDelta_Interactor_Offset), 0, null);
            bool axis = BoolMarshaller.FromNative(IntPtr.Add(buffer, GetSlideDelta_Axis_Offset), 0, null);
            float returnValue = GetSlideDelta_Implementation(interactor, axis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    
}